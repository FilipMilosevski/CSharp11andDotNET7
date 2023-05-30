using SQLite;

namespace CompanyApp
{
    public class InitDatabase
    {
        SQLiteAsyncConnection Database;

        public InitDatabase()
        {
        }
        public const string DatabaseFilename = "TodoSQLite.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        
public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);
        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(DatabasePath, Flags);
            var result = await Database.CreateTableAsync<User>();
        }

        public async Task<List<User>> GetItemsAsync()
        {
            await Init();
            return await Database.Table<User>().ToListAsync();
        }

        public async Task<User> GetItemAsync(string username, string password)
        {
            await Init();
            return await Database.Table<User>().Where(i => i.UserName == username && i.Password == password).FirstOrDefaultAsync();
        }

        public async Task<int> SaveItemAsync(User item)
        {
            await Init();
            return await Database.InsertAsync(item);
        }

        public async Task<int> DeleteItemAsync(User item)
        {
            await Init();
            return await Database.DeleteAsync(item);
        }
    }

}
