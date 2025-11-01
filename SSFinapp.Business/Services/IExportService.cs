namespace SSFinapp.Business.Services;

/// <summary>
/// Excel export servisi interface
/// </summary>
public interface IExportService
{
    Task<string> ExportProductsToExcelAsync(string filePath);
    Task<string> ExportStockTransactionsToExcelAsync(string filePath);
    Task<string> ExportCustomersToExcelAsync(string filePath);
    Task<string> ExportCurrentAccountTransactionsToExcelAsync(string filePath);
}

