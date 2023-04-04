using System.Configuration;



namespace SL_TestAutomationFramework
{
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string InventoryPageUrl = ConfigurationManager.AppSettings["inventorypage_url"];
        public static readonly string CartPageUrl = ConfigurationManager.AppSettings["cartpage_url"];

        public static readonly string UserName = ConfigurationManager.AppSettings["username"];
        public static readonly string Password = ConfigurationManager.AppSettings["password"];
    }

    //We will use this class to read from the Testhost DLL file
}