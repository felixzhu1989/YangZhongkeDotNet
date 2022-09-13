using Zack.Commons;

namespace ConsoleAppEFCoreCongestiveModel
{
    public class User
    {
        public long Id { get; init; }//特征1，只读属性
        public DateTime CreateTime { get; init; }//特征1
        public string Name { get; private set; }//特征1
        public int Credits { get;private set; }//特征1
        private string? passwordHash;//特征3,成员变量映射到数据库
        private string? remark;
        public string? Remark
        {
            get { return remark; }
        }//特征4
        public string? Tag { get; set; }//特征5，不映射到数据库
        //EF Core从数据库中加载数据然后生成User对象返回用
        private User()//只给EF Core用，特征2
        {
            
        }
        public User(string yhm)//故意写的与Name不一致，给程序员用，特征2
        {
            Name=yhm;
            CreateTime=DateTime.Now;
            Credits = 10;
        }

        public void ChangeName(string newName)
        {
            if (newName.Length < 3)
            {
                Console.WriteLine("用户名长度不能小于3");
                return;
            }
            Name = newName;
        }

        public void ChangePassword(string pwd)
        {
            if (pwd.Length < 3)
            {
                Console.WriteLine("密码长度不能小于3");
                return;
            }
            passwordHash = HashHelper.ComputeMd5Hash(pwd);
        }
    }
}
