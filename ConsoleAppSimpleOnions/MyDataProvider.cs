using ClassLibrarySimpleOnions;

namespace ConsoleAppSimpleOnions
{
    public class MyDataProvider:IDataProvider
    {
        public async IAsyncEnumerable<EmailInfo> GetEmailInfosAsync()
        {
            var lines = await File.ReadAllLinesAsync("d://temp.txt");
            foreach (var line in lines)
            {
                var segments = line.Split('|');
                var email = segments[0];
                var title = segments[1];
                var body = segments[2];
                yield return new EmailInfo(email, title, body);
            }
        }
    }
}
