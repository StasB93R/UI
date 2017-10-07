using SQLite;


namespace UI
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
