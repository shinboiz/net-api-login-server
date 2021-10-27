
namespace LoginApi.Models {
    public class LoginCredential {

        public string UserName { get; set; }

        public string Password { get; set; }

        public LoginCredential(string userName, string password) {
            this.UserName = userName;
            this.Password = password;
        }
    }
}