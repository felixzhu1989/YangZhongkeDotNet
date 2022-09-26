namespace FileService.Infrastructure.Services
{
    public class SMBStorageOptions
    {
        //千万不要写成private set；会导致不注入。
        //项目里除了实体类、ValueObject、DTO之外，别的类尽量不要写成private set;
        /// <summary>
        /// 根目录，从配置中读取
        /// </summary>
        public string WorkingDir { get; set; }
    }
}
