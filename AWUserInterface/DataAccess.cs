using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace AWUserInterface
{
    class DataAccess
    {
        public static List<int> getProductModelIDs()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<int> productModelIDs = new List<int>();

                string select = "SELECT DISTINCT " +
                        "Production.Product.ProductModelID " +
                        "FROM " +
                        "Production.Product " +
                        "WHERE Product.ProductModelID IS NOT NULL ORDER BY ProductModelID";
                productModelIDs = connection.Query<int>(select).ToList();
                return productModelIDs;
            }
        }
    }
}
