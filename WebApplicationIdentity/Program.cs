using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplicationIdentity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
