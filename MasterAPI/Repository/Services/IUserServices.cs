using MasterAPI.Models;

namespace MasterAPI.Repository.Services
{
    public interface IUserServices
    {
    Task<UserRequestModel> CreateUser(UserRequestModel user);
    }
}
