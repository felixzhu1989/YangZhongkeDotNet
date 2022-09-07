using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using WebApplicationJwt;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

#region JWT
//����Swagger��������Authorize��ť��ť
builder.Services.AddSwaggerGen(options =>
{
    var scheme = new OpenApiSecurityScheme()
    {
        Description = "Authorization header. Example:'Bearer xxx(JWTToken)'", //��ʾ���
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

        //var key = builder.Configuration.GetSection("JwtOptions:SigningKey").Value;
        //var keyBytes = Encoding.UTF8.GetBytes(key);
        var secKey = new SymmetricSecurityKey(keyBytes);
        options.TokenValidationParameters = new()
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = secKey
        };
    });

//���ü��JwtVersion�м��
builder.Services.Configure<MvcOptions>(options =>
{
    options.Filters.Add<JwtVersionCheckFilter>();
});
#endregion


#region Identity
//���������Ķ�Ӧ�����ݿ⣬����������Scoped
builder.Services.AddDbContext<MyDbContext>(option =>
{
    //ָ�����ӵ����ݿ�
    var connStr = builder.Configuration.GetSection("ConnectionStrings:SqlServer").Value;
    option.UseSqlServer(connStr);
});

//Identity�������
builder.Services.AddDataProtection();
builder.Services.AddIdentityCore<MyUser>(option =>
{
    //���ö������Ҫ�󽵵�
    option.Password.RequireDigit = false;//���벻ҪҪ������
    option.Password.RequiredLength = 3;//���볤��3�͹���
    option.Password.RequireLowercase = false;
    option.Password.RequireUppercase = false;
    option.Password.RequireNonAlphanumeric = false;
    //ͨ�������������ã����������������ɵ�token����һ�����֣���������ɺܳ����ַ���
    //����ǰ��������ӷ��͵��û����䣬��������PasswordResetTokenProvider
    option.Tokens.PasswordResetTokenProvider = TokenOptions.DefaultEmailProvider;
    option.Tokens.EmailConfirmationTokenProvider = TokenOptions.DefaultEmailProvider;
    //���õ�¼ʧ������ʱ�������ʱ��
    option.Lockout.MaxFailedAccessAttempts = 10;//����10������
    option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);//����1����
});
//��ʵ���ܽ�����ϵ
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

app.UseHttpsRedirection();
//Jwt�м��
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
