namespace DiAPi.Data
{
    public class SqlDataRepo : IDataRepo
    {
        #region Methods
        public string ReturnData()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--> Getting data from SQL Database...");
            Console.ResetColor();

            return("SQL Data from DB");
        }
        #endregion
    }
}