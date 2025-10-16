using MasterAPI.Models;
using MasterAPI.Repository.Services;
using System.Formats.Asn1;

namespace MasterAPI.Repository.Implementation
{
    public class UserServices : IUserServices
    {
        public async Task<UserRequestModel> CreateUser (UserRequestModel user)
        {
            await Task.Delay(100); // simulate database or API call
            return user;
        }
    }
}
