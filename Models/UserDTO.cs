
namespace LoginApi.Models {
    public class UserDTO {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public int Age { get; set; }

        public UserDTO(string userId, string userName, int age) {
            this.UserId = userId;
            this.UserName = userName;
            this.Age = age;
        }

        public UserDTO(User user) {
            this.UserId = user.UserId;
            this.UserName = user.UserName;
            this.Age = user.Age;
        }
    }
}