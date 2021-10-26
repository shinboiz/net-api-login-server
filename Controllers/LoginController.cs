using Microsoft.AspNetCore.Mvc;
using LoginApi.Models;
using Microsoft.Extensions.Logging;

namespace LoginApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class LoginController {

        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public User Get() {
            return new User("111111111", "steve", 30);
        }

    }
}