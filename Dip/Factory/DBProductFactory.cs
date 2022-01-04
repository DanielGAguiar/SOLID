using Dip.Model;
using System.Configuration;


namespace Dip.Factory
{
    class DBProductFactory
    {

        public static DBProduct Create()
        {
            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SQLProdutProcess();
            }
            else
            {
                return new MongoDBProcess();
            }
        }

    }
}
