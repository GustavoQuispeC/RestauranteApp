
namespace RestauranteApp.Server.Services
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<FileUpload> _logger;

        public FileUpload(IWebHostEnvironment webHostEnvironment, ILogger<FileUpload> logger)
        {
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }

        public async Task<string> UploadFileAsync(string? base64Imagen, string? FileName)
        {
            if (string.IsNullOrWhiteSpace(base64Imagen) || string.IsNullOrWhiteSpace(FileName))
            {
                return string.Empty;
            }

            try
            {
                var carpeta = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads");
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }

                var bytes = Convert.FromBase64String(base64Imagen);

                var rutaCompleta = Path.Combine(carpeta, FileName);

                await using var fileStream = new FileStream(rutaCompleta, FileMode.Create);
                await fileStream.WriteAsync(bytes, 0, bytes.Length);

                return $"/uploads/{FileName}";
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Error al cargar el archivo {archivo}", FileName);
                return string.Empty;
            }
        }
    }
}
