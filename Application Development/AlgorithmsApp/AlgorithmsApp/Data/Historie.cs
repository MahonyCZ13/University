using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using AlgorithmsApp.Models;

namespace AlgorithmsApp.Data
{
    public class HistorieDB
    {
        readonly SQLiteAsyncConnection conn;

        public HistorieDB(string dbpath)
        {
            conn = new SQLiteAsyncConnection(dbpath);
            conn.CreateTableAsync<Model>().Wait();
        }
        public Task<List<Model>> GetHistoryAsync()
        {
            return conn.Table<Model>().ToListAsync();
        }
        public Task<Model> GetSingleAsync(int Id)
        {
            return conn.Table<Model>().Where(i => i.Id == Id).FirstOrDefaultAsync();
        }
        public Task<int> SaveHistory(Model model)
        {
            if(model.Id == 0) return conn.UpdateAsync(model);
            else return conn.InsertAsync(model);
        }
        public Task<int> DeleteHistory(Model model)
        {
            return conn.DeleteAsync(model);
        }
    }
}