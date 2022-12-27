using WS.WebUI.Library.Models;

namespace WS.WebUI.Library.Data
{
    public interface IUserData
    {
        Task AddUserAsync(string firstName, string lastName, string email);
        Task DeleteUserAsync(string id);
        Task<List<UserModel>> GetAllRecordsAsync();
        Task<UserModel?> GetRecordByIdAsync(int id);
        Task UpdateUserAsync(string id, string firstName, string lastName, string email);
    }
}