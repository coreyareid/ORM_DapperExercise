using System;
namespace ORM_Dapper
{
    public interface IProductRepository
    {
        // Stubbed out methods for DapperProductRepository.cs
        IEnumerable<Product> GetAllProducts();
        void CreateProduct(string name, double price, int categoryID);
    }
}

