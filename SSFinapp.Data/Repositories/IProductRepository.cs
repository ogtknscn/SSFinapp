using SSFinapp.Domain.Entities;

namespace SSFinapp.Data.Repositories;

/// <summary>
/// Ürün repository interface
/// </summary>
public interface IProductRepository : IRepository<Product>
{
    Task<IEnumerable<Product>> GetActiveProductsAsync();
    Task<Product?> GetProductWithTransactionsAsync(int id);
}

