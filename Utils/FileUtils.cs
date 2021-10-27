using System;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace LoginApi.Utils {
    public class FileUtils {
        public static async Task WriteFile(string content, string fileName, ILogger logger) {

            // Set a variable to the Documents path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    
            // TODO verify directory exists, Name is not null, Path is not null, Body is not null
            string fullPath = System.IO.Path.Combine(docPath, fileName);

            logger.LogInformation(string.Format("Writing data to file = {0}", fullPath));

            // Simplest way to write to file
            await System.IO.File.WriteAllTextAsync(fullPath, content);
        }
    }
}