namespace WS.WebUI.Library.DataAccess
{
    public interface ISQLDataAccess
    {
        Task<List<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters, string database = "Default");
        Task SaveDataAsync<T>(string storedProcedure, T parameters, string datavse = "Default");
    }
}