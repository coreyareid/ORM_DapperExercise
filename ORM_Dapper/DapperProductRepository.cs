using System;
using Dapper;
using System.Data;

namespace ORM_Dapper
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;

        // Perameterized Constructor 
        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        // Methodused to see all products in bestbuy Products
        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM bestbuy.products;");
        }

        // Method used to create product
        public void CreateProduct(string name, double price, int categoryID)
        {
            _connection.Execute("INSERT INTO products (Name, Price, CategoryID) " +
                "Values (@name, @price, @categoryID);",
                new { name = name, price = price, categoryID = categoryID });
        }

        // Method used to update product
        public void UpdateProduct(int productID, string Name)
        {
            _connection.Execute("UPDATE products SET Name = @Name WHERE ProductID = @productID;",
                new { productName = Name, productID = productID });
        }

        // Method used to delete product
        public void DeleteProduct(int productID)
        {
            _connection.Execute("DELETE FROM products WHERE ProductID = @productID;",
                new { productID = productID });
        }
    }
}
