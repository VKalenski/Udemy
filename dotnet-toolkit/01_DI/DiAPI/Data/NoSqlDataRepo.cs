#region Usings
using DiAPi.DataServices;
#endregion

namespace DiAPi.Data
{
    public class NoSqlDataRepo : IDataRepo
    {
        #region Fields
        private readonly IServiceScopeFactory _scopeFactory;
        // private readonly IDataService _dataService;
        #endregion

        #region Ctor
        public NoSqlDataRepo(IServiceScopeFactory scopeFactory)
        {
            //_dataService = dataService;
            _scopeFactory = scopeFactory;
        }
        #endregion

        #region Methods
        public string ReturnData()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> Getting data from No SQL Database...");
            using (var scope = _scopeFactory.CreateScope())
            {
                var dataService = scope.ServiceProvider.GetRequiredService<IDataService>();
                dataService.GetProductData("https://something.com/api");
                Console.ResetColor();

                return("No SQL Data from DB");
            }
        }
        #endregion
    }
}