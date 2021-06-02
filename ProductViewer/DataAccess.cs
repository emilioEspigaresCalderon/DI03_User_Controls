﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace AWProductViewer
{
    class DataAccess
    {
        
        public static List<Product> getProductModel(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Product> products = new List<Product>();

                string select = "SELECT DISTINCT " +
                        "Production.ProductModel.ProductModelID, " +
                        "Production.Product.ProductID AS ProductModel, " +
                        "Production.Product.Name, " +
                        "Production.Product.Size, Production.Product.Color " +
                        "FROM " +
                        "Production.Product " +
                        "INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID " +
                        "INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID " +
                        "INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID " +
                        "INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID " +
                        "INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID " +
                        $"WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL AND Production.ProductModel.ProductModelId = '{ id }' ORDER BY ProductModel";
                products = connection.Query<Product>(select).ToList();
                return products;
            }
        }

        public static ProductImage GetImage(int id)
        {
            string connString = ConfigurationManager.ConnectionStrings["AdventureWorks2016"].ConnectionString;
            ProductImage product = new ProductImage();

            using (IDbConnection conn = new SqlConnection(connString))
            {
                string select = "SELECT " +
                        "Product.ProductId, Name, ProductPhoto.ProductPhotoID, " +
                        "LargePhoto, LargePhotoFileName " +
                        "FROM " +
                        "Production.Product " +
                        "INNER JOIN Production.ProductProductPhoto ON Product.ProductID=ProductProductPhoto.ProductID " +
                        "INNER JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID=ProductPhoto.ProductPhotoID " +
                        $"WHERE Product.ProductModelId = '{ id }'";
                product = conn.Query<ProductImage>(select).FirstOrDefault();
                return product;
            }
        }
    }
}
