using Microsoft.AspNetCore.Http;
using System.Drawing;
using System.Drawing.Imaging;

namespace Platform.MobileCachRegisterCore.Common
{
    public static class Utils
    {
        public static bool IsAjaxRequest(HttpRequest request)
        {
            return string.Equals(request.Query["X-Requested-With"], "XMLHttpRequest", StringComparison.Ordinal) ||
                string.Equals(request.Headers["X-Requested-With"], "XMLHttpRequest", StringComparison.Ordinal);
        }

        public static string Base64Encode(string plainText)
        {
            try
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                return Convert.ToBase64String(plainTextBytes);
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public static string Base64Decode(string base64EncodedData)
        {
            try
            {
                var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public static string ResizeImage(string base64Image)
        {
            byte[] imageBytes = Convert.FromBase64String(base64Image);
            using (var stream = new MemoryStream(imageBytes))
            {
                using (var image = Image.FromStream(stream))
                {
                    int quality = 90;
                    int width = image.Width;
                    int height = image.Height;

                    while (imageBytes.Length > 16000)
                    {
                        width = (int)(width * 0.9);
                        height = (int)(height * 0.9);

                        using (var resizedImage = new Bitmap(image, width, height))
                        {
                            using (var output = new MemoryStream())
                            {
                                // compress image to reduce file size
                                var encoder = ImageCodecInfo.GetImageEncoders().First(c => c.FormatID == image.RawFormat.Guid);
                                var parameters = new EncoderParameters(1);
                                parameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);
                                resizedImage.Save(output, encoder, parameters);

                                imageBytes = output.ToArray();
                            }
                        }
                    }

                    return "data:image/*;base64," + Convert.ToBase64String(imageBytes);
                }
            }
        }
    }
}
