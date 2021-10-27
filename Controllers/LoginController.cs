using Microsoft.AspNetCore.Mvc;
using LoginApi.Models;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System;
using System.Threading.Tasks;

namespace LoginApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class LoginController: ControllerBase {

        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        
        // POST: Login
        [HttpPost]
        public async Task<ActionResult<UserDTO>> Post(LoginCredential credential) {
            _logger.LogInformation("Recieving login request");

            // Find User with credential
            var foundUser = new User(credential);

            // Parse user object to JSON
            var userJson = JsonSerializer.Serialize(credential);

            // Write user data to file in JSON format
            await WriteFile(userJson, "user.txt");

            return CreatedAtAction(
                nameof(Post),
                new { id = foundUser.UserId },
                new UserDTO(foundUser)
            );
        }

        private async Task WriteFile(string content, string fileName) {
            // Set a variable to the Documents path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    
            // TODO verify directory exists, Name is not null, Path is not null, Body is not null
            string fullPath = System.IO.Path.Combine(docPath, fileName);

            // Simplest way to write to file
            await System.IO.File.WriteAllTextAsync(fullPath, content);
        }
    }
}