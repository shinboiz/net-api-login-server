using LoginApi.Utils;

namespace LoginApi.Models {
    public class User {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }

        public User(string userId, string userName, string password, int age) {
            this.UserId = userId;
            this.UserName = userName;
            this.Password = password;
            this.Age = age;
        }

        public User(LoginCredential credential) {
            this.UserId = StringUtils.RandomString(8);
            this.UserName = credential.UserName;
            this.Password = credential.Password;
            this.Age = 30;
        }
    }
}