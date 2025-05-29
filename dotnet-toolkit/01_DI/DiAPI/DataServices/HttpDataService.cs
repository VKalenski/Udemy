namespace DiAPi.DataServices
{
    public class HttpDataService : IDataService
    {
        #region Methods
        public string GetProductData(string url)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---> Getting Product data...");
            Console.ResetColor();

            return "Some PRODUCT data...";
        }
        #endregion
    }
}