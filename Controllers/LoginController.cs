using Microsoft.AspNetCore.Mvc;
using LoginApi.Models;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net;
using LoginApi.Utils;

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

            // Mock an failure
            if (credential.UserName.ToLower() == "failure") {
                return new NotFoundObjectResult(new ErrorDTO((int)HttpStatusCode.NotFound, string.Format("No user with username = {0}", credential.UserName)));
            }

            // Find User with credential
            var foundUser = new User(credential);

            // Parse user object to JSON
            var userJson = JsonSerializer.Serialize(credential);

            // Write user data to file in JSON format
            await FileUtils.WriteFile(userJson, "user.txt", _logger);

            return CreatedAtAction(
                nameof(Post),
                new { id = foundUser.UserId },
                new UserDTO(foundUser)
            );
        }
    }
}