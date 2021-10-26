
namespace LoginApi.Models {
    public class User {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public int Age { get; set; }

        public User(string userId, string userName, int age) {
            this.UserId = userId;
            this.UserName = userName;
            this.Age = age;
        }
    }
}