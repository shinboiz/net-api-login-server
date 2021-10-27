
namespace LoginApi.Models {
    public class ErrorDTO {
        public int ErrorCode { get; set; }

        public string Message { get; set; }

        public ErrorDTO(int errorCode, string message) {
            this.ErrorCode = errorCode;
            this.Message = message;            
        }
    }
}