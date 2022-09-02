using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

//模拟计算一个jwt
var claims=new List<Claim>
{
    //通常使用枚举，用标准取值
    new Claim(ClaimTypes.NameIdentifier,"888"),
    new Claim(ClaimTypes.Name,"felix"),
    new Claim(ClaimTypes.Role,"admin"),
    new Claim(ClaimTypes.HomePhone,"999"),
    //也可以自定义
    new Claim("Passport","123456"),
    new Claim("QQ","654321"),
    new Claim("Id","666")
};
//通常只有服务器知道secKey，我们这里只是模拟
var key="sdfaqwerasdfg@ased_ds#";
//过期时间1小时
var expires = DateTime.Now.AddHours(1);
var secBytes=Encoding.UTF8.GetBytes(key);
var secKey = new SymmetricSecurityKey(secBytes);
var credentials = new SigningCredentials(secKey, SecurityAlgorithms.HmacSha256Signature);
var tokenDescriptor = new JwtSecurityToken(claims:claims,expires: expires,signingCredentials: credentials);
var jwt = new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);

Console.WriteLine(jwt);

//模拟解密jwt字符串（公开算法）
var strs=jwt.Split('.');//jwt三个部分使用.分隔的
var header = strs[0];
var payload = strs[1];
var signature = strs[2];

Console.WriteLine(JwtDecode(header));
Console.WriteLine(JwtDecode(payload));
Console.WriteLine(JwtDecode(signature));

string JwtDecode(string s)
{
    s = s.Replace('-', '+').Replace('_', '/');
    switch (s.Length%4)
    {
        case 2:
            s += "==";
            break;
        case 3:
            s+="=";
            break;
    }
    var bytes = Convert.FromBase64String(s);
    return Encoding.UTF8.GetString(bytes);
}

//模拟解密jwt字符串（校验签名）
//瞎写一个Key
var keyBad = "sdfaqwerasdfg@ased_ds#??";
JwtSecurityTokenHandler tokenHandler = new();
TokenValidationParameters valParam = new();
var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyBad));
valParam.IssuerSigningKey = securityKey;
valParam.ValidateIssuer = false;
valParam.ValidateAudience = false;
ClaimsPrincipal claimsPrincipal = tokenHandler.ValidateToken(jwt,
    valParam, out SecurityToken secToken);
foreach (var claim in claimsPrincipal.Claims)
{
    Console.WriteLine($"{claim.Type}={claim.Value}");
}