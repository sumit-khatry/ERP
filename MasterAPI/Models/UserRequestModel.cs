namespace MasterAPI.Models
{
    public class UserRequestModel
    {
        public string UserName { get; set; } =string.Empty; 
        public string Password { get; set; }= string.Empty;
        public string Email { get; set; } = string.Empty;
        public string phoneNumber { get; set; } = string.Empty;
    }
}
