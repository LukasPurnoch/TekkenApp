using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace TekkenApp.Database
{
    class Database_Connection
    {
        private SQLiteAsyncConnection database;

        public Database_Connection(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Profile.Attack_TYPE>().Wait();
        }

        public Task<int> SaveAttack(Profile.Attack_TYPE item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<List<Profile.Attack_TYPE>> GetAll()
        {
            return database.QueryAsync<Profile.Attack_TYPE>("SELECT * FROM [Profile.Attack_TYPE] ORDER BY ID DESC");
        }


    }
}
