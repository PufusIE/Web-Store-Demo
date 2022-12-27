using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.WebUI.Library.DataAccess;
using WS.WebUI.Library.Models;

namespace WS.WebUI.Library.Data
{
    public class UserData : IUserData
    {
        private readonly ISQLDataAccess _db;

        public UserData(ISQLDataAccess db)
        {
            _db = db;
        }

        //Create
        public async Task AddUserAsync(string firstName, string lastName, string email)
        {
            string sql = "spPerson_AddById";
            await _db.SaveDataAsync(sql, new { FirstName = firstName, LastName = lastName, Email = email });
        }

        //Delete
        public async Task DeleteUserAsync(string id)
        {
            string sql = "spPerson_HardDeleteById";
            await _db.SaveDataAsync(sql, new { Id = id });
        }

        //Update 
        public async Task UpdateUserAsync(string id, string firstName, string lastName, string email)
        {
            string sql = "spPerson_UpdateRecord";
            await _db.SaveDataAsync(sql, new { Id = id, FirstName = firstName, LastName = lastName, Email = email });
        }

        //Read
        public async Task<List<UserModel>> GetAllRecordsAsync()
        {
            string sql = "spPerson_GetAll";
            var output = await _db.LoadDataAsync<UserModel, dynamic>(sql, new { });

            return output.ToList();
        }

        public async Task<UserModel?> GetRecordByIdAsync(int id)
        {
            string sql = "spPerson_GetById";
            var output = await _db.LoadDataAsync<UserModel, dynamic>(sql, new { Id = id });
            return output.FirstOrDefault();
        }
    }
}
