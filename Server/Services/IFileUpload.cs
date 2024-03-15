namespace RestauranteApp.Server.Services
{
    public interface IFileUpload
    {
        Task<string> UploadFileAsync(string? base64Imagen, string? FileName);
    }
}
