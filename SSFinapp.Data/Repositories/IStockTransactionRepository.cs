using SSFinapp.Domain.Entities;

namespace SSFinapp.Data.Repositories;

/// <summary>
/// Stok hareketi repository interface
/// </summary>
public interface IStockTransactionRepository : IRepository<StockTransaction>
{
    Task<IEnumerable<StockTransaction>> GetTransactionsByProductIdAsync(int productId);
    Task<IEnumerable<StockTransaction>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate);
}

