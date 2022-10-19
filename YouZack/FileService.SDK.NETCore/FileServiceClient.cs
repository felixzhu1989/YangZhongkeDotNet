using System.Net.Http.Headers;
using System.Security.Claims;
using Zack.Commons;
using Zack.JWT;

namespace FileService.SDK.NETCore
{
    public class FileServiceClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly Uri _serverRoot;
        private readonly JWTOptions _optionsSnapshot;
        private readonly ITokenService _tokenService;

        public FileServiceClient(IHttpClientFactory httpClientFactory,Uri serverRoot,JWTOptions optionsSnapshot,ITokenService tokenService)
        {
            _httpClientFactory = httpClientFactory;
            _serverRoot = serverRoot;
            _optionsSnapshot = optionsSnapshot;
            _tokenService = tokenService;
        }

        public Task<FileExistsResponse?> FileExistsAsync(long fileSize, string sha256Hash,
            CancellationToken cancellationToken = default)
        {
            string relativeUrl =FormattableStringHelper.BuildUrl($"api/Uploader/FileExists?fileSize={fileSize}&sha256Hash={sha256Hash}");
            Uri requestUri = new Uri(_serverRoot, relativeUrl);
            var httpClient = _httpClientFactory.CreateClient();
            return httpClient.GetJsonAsync<FileExistsResponse>(requestUri, cancellationToken);
        }

        string BuildToken()
        {
            //因为JWT的key等机密信息只有服务器端知道，因此可以这样非常简单的读到配置
            Claim claim = new Claim(ClaimTypes.Role, "Admin");
            return _tokenService.BuildToken(new Claim[] { claim }, _optionsSnapshot);
        }

        public async Task<Uri?> UploadAsync(FileInfo file, CancellationToken cancellationToken = default)
        {
            string token = BuildToken();
            using MultipartFormDataContent content=new MultipartFormDataContent();
            using var fileContent = new StreamContent(file.OpenRead());
            content.Add(fileContent,"file",file.Name);
            var httpClient = _httpClientFactory.CreateClient();
            Uri requestUri = new Uri($"{_serverRoot}/Uploader/Upload");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var respMsg=await httpClient.PostAsync(requestUri, content,cancellationToken);
            string respString = await respMsg.Content.ReadAsStringAsync(cancellationToken);
            if (!respMsg.IsSuccessStatusCode)
                throw new HttpRequestException($"上传失败，状态码：{respMsg.StatusCode}，响应报文：{respString}");
            return respString.ParseJson<Uri>();
        }
    }
}