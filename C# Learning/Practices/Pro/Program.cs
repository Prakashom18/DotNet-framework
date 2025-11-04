using System;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://example.com";
        string filePath = "downloaded_page.html";

        Console.WriteLine("Downloading file asynchronously...");

        await DownloadFileWithProgressAsync(url, filePath);

        Console.WriteLine("\n✅ Download complete!");
    }

    static async Task DownloadFileWithProgressAsync(string url, string filePath)
    {
        // Ignore SSL certificate errors (FOR TESTING ONLY)
        HttpClientHandler handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
        };

        using (HttpClient client = new HttpClient(handler))
        using (HttpResponseMessage response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
        using (Stream contentStream = await response.Content.ReadAsStreamAsync(),
                      fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
        {
            var totalBytes = response.Content.Headers.ContentLength ?? 0L;
            var buffer = new byte[8192];
            long totalRead = 0;
            int bytesRead;

            while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                await fileStream.WriteAsync(buffer, 0, bytesRead);
                totalRead += bytesRead;

                if (totalBytes > 0)
                {
                    double progress = (double)totalRead / totalBytes * 100;
                    Console.Write($"\rProgress: {progress:F2}%");
                }
            }
        }
    }
}
