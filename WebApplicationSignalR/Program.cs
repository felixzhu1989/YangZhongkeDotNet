using Microsoft.AspNetCore.Identity;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebApplicationSignalR;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

#region Jwt
//启用Swagger，并配置Authorize按钮按钮
builder.Services.AddSwaggerGen(options =>
{
    var scheme = new OpenApiSecurityScheme()
    {
        Description = "Authorization header. Example:'Bearer xxx(JWTToken)'", //提示语句
        Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Authorization" },
        Scheme = "oauth2",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey
    };
    options.AddSecurityDefinition("Authorization", scheme);
    var requirement = new OpenApiSecurityRequirement { [scheme] = new List<string>() };
    options.AddSecurityRequirement(requirement);
});

builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("JwtOptions"));
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        var jwtOptions = builder.Configuration.GetSection("JwtOptions").Get<JwtOptions>();
        var keyBytes = Encoding.UTF8.GetBytes(jwtOptions.SigningKey);
        var secKey = new SymmetricSecurityKey(keyBytes);
        options.TokenValidationParameters = new()
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = secKey
        };
        options.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                //websocket不支持自定义报文头，因此需要把jwt通过url种的QuerySting传递
                //然后在服务端的OnMessageReceive种，把QuerySting种的jwt读出来，赋值给context.Token
                var accessToken = context.Request.Query["access_token"];
                var path = context.HttpContext.Request.Path;
                if (!string.IsNullOrEmpty(accessToken) && path.StartsWithSegments("/MyHub"))
                    context.Token = accessToken;
                return Task.CompletedTask;
            }
        };
    });

//配置检查JwtVersion中间件
builder.Services.Configure<MvcOptions>(options =>
{
    options.Filters.Add<JwtVersionCheckFilter>();
});
#endregion




#region SignalR
//那些前端是可信任的
/*builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("https://localhost:7192")
            .AllowAnyMethod().AllowAnyHeader().AllowCredentials();
    });
});*/
builder.Services.AddCors();

//配置SignalR,配置redis消息中心服务器
builder.Services.AddSignalR().AddStackExchangeRedis("127.0.0.1:6379", options =>
{
    options.Configuration.ChannelPrefix = "SignalR_";//添加前缀，防止与其他使用redis的程序产生数据混乱
});
#endregion


#region Identity
//配置上下文对应的数据库，生命周期是Scoped
builder.Services.AddDbContext<MyDbContext>(option =>
{
    //指定连接的数据库
    var connStr = builder.Configuration.GetSection("ConnectionStrings:SqlServer").Value;
    option.UseSqlServer(connStr);
});

//Identity框架配置
builder.Services.AddDataProtection();
builder.Services.AddIdentityCore<MyUser>(option =>
{
    //配置对密码的要求降低
    option.Password.RequireDigit = false;//密码不要要求数字
    option.Password.RequiredLength = 3;//密码长度3就够了
    option.Password.RequireLowercase = false;
    option.Password.RequireUppercase = false;
    option.Password.RequireNonAlphanumeric = false;
    //通过邮箱密码重置，这样重置密码生成的token就是一串数字，否则会生成很长的字符串
    //如果是把重置链接发送到用户邮箱，则不用配置PasswordResetTokenProvider
    option.Tokens.PasswordResetTokenProvider = TokenOptions.DefaultEmailProvider;
    option.Tokens.EmailConfirmationTokenProvider = TokenOptions.DefaultEmailProvider;
    //配置登录失败锁定时间和锁定时间
    option.Lockout.MaxFailedAccessAttempts = 10;//尝试10次锁定
    option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);//锁定1分钟
});
//和实体框架建立关系
var idBuilder = new IdentityBuilder(typeof(MyUser), typeof(MyRole), builder.Services);
idBuilder.AddEntityFrameworkStores<MyDbContext>().AddDefaultTokenProviders()
    .AddRoleManager<RoleManager<MyRole>>()
    .AddUserManager<UserManager<MyUser>>();


#endregion


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//app.UseCors();//跨域访问，在UseHttpsRedirection之前
app.UseCors(x => x.WithOrigins("https://localhost:7192")
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowCredentials()
);

app.UseHttpsRedirection();

//Jwt中间件
app.UseAuthentication();
app.UseAuthorization();

app.MapHub<MyHub>("/MyHub");//，在MapControllers之前




app.MapControllers();

app.Run();
