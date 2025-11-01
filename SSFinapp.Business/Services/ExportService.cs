using ClosedXML.Excel;

namespace SSFinapp.Business.Services;

/// <summary>
/// Excel export servisi
/// </summary>
public class ExportService : IExportService
{
    private readonly IStockService _stockService;
    private readonly ICurrentAccountService _currentAccountService;
    
    public ExportService(IStockService stockService, ICurrentAccountService currentAccountService)
    {
        _stockService = stockService;
        _currentAccountService = currentAccountService;
    }
    
    public async Task<string> ExportProductsToExcelAsync(string filePath)
    {
        var products = await _stockService.GetAllProductsAsync();
        
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Ürünler");
        
        // Başlıklar
        worksheet.Cell(1, 1).Value = "ID";
        worksheet.Cell(1, 2).Value = "Ürün Adı";
        worksheet.Cell(1, 3).Value = "Birim";
        worksheet.Cell(1, 4).Value = "Aktif";
        worksheet.Cell(1, 5).Value = "Oluşturma Tarihi";
        
        // Stil
        var headerRange = worksheet.Range(1, 1, 1, 5);
        headerRange.Style.Font.Bold = true;
        headerRange.Style.Fill.BackgroundColor = XLColor.LightBlue;
        
        // Veri
        int row = 2;
        foreach (var product in products)
        {
            worksheet.Cell(row, 1).Value = product.Id;
            worksheet.Cell(row, 2).Value = product.Ad;
            worksheet.Cell(row, 3).Value = product.Birim;
            worksheet.Cell(row, 4).Value = product.Aktif ? "Evet" : "Hayır";
            worksheet.Cell(row, 5).Value = product.OlusturmaTarihi.ToString("dd.MM.yyyy HH:mm");
            row++;
        }
        
        worksheet.Columns().AdjustToContents();
        workbook.SaveAs(filePath);
        
        return filePath;
    }
    
    public async Task<string> ExportStockTransactionsToExcelAsync(string filePath)
    {
        var transactions = await _stockService.GetAllTransactionsAsync();
        
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Stok Hareketleri");
        
        worksheet.Cell(1, 1).Value = "ID";
        worksheet.Cell(1, 2).Value = "Tarih";
        worksheet.Cell(1, 3).Value = "İşlem Tipi";
        worksheet.Cell(1, 4).Value = "Ürün ID";
        worksheet.Cell(1, 5).Value = "Miktar";
        worksheet.Cell(1, 6).Value = "Birim";
        worksheet.Cell(1, 7).Value = "Açıklama";
        
        var headerRange = worksheet.Range(1, 1, 1, 7);
        headerRange.Style.Font.Bold = true;
        headerRange.Style.Fill.BackgroundColor = XLColor.LightGreen;
        
        int row = 2;
        foreach (var trans in transactions.OrderByDescending(t => t.Tarih))
        {
            worksheet.Cell(row, 1).Value = trans.Id;
            worksheet.Cell(row, 2).Value = trans.Tarih.ToString("dd.MM.yyyy HH:mm");
            worksheet.Cell(row, 3).Value = trans.IslemTipi.ToString();
            worksheet.Cell(row, 4).Value = trans.UrunId;
            worksheet.Cell(row, 5).Value = trans.Miktar;
            worksheet.Cell(row, 6).Value = trans.Birim;
            worksheet.Cell(row, 7).Value = trans.Aciklama;
            row++;
        }
        
        worksheet.Columns().AdjustToContents();
        workbook.SaveAs(filePath);
        
        return filePath;
    }
    
    public async Task<string> ExportCustomersToExcelAsync(string filePath)
    {
        var customers = await _currentAccountService.GetAllCustomersAsync();
        
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Müşteriler");
        
        worksheet.Cell(1, 1).Value = "ID";
        worksheet.Cell(1, 2).Value = "Müşteri Adı";
        worksheet.Cell(1, 3).Value = "Telefon";
        worksheet.Cell(1, 4).Value = "Email";
        worksheet.Cell(1, 5).Value = "Adres";
        worksheet.Cell(1, 6).Value = "Aktif";
        worksheet.Cell(1, 7).Value = "Bakiye";
        
        var headerRange = worksheet.Range(1, 1, 1, 7);
        headerRange.Style.Font.Bold = true;
        headerRange.Style.Fill.BackgroundColor = XLColor.LightYellow;
        
        int row = 2;
        foreach (var customer in customers)
        {
            var balance = await _currentAccountService.GetCustomerBalanceAsync(customer.Id);
            
            worksheet.Cell(row, 1).Value = customer.Id;
            worksheet.Cell(row, 2).Value = customer.Ad;
            worksheet.Cell(row, 3).Value = customer.Telefon;
            worksheet.Cell(row, 4).Value = customer.Email;
            worksheet.Cell(row, 5).Value = customer.Adres;
            worksheet.Cell(row, 6).Value = customer.Aktif ? "Evet" : "Hayır";
            worksheet.Cell(row, 7).Value = balance;
            row++;
        }
        
        worksheet.Columns().AdjustToContents();
        workbook.SaveAs(filePath);
        
        return filePath;
    }
    
    public async Task<string> ExportCurrentAccountTransactionsToExcelAsync(string filePath)
    {
        var transactions = await _currentAccountService.GetAllTransactionsAsync();
        
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Cari Hareketler");
        
        worksheet.Cell(1, 1).Value = "ID";
        worksheet.Cell(1, 2).Value = "Tarih";
        worksheet.Cell(1, 3).Value = "Müşteri ID";
        worksheet.Cell(1, 4).Value = "Malzeme";
        worksheet.Cell(1, 5).Value = "Tutar";
        worksheet.Cell(1, 6).Value = "Alınan";
        worksheet.Cell(1, 7).Value = "Verilen";
        worksheet.Cell(1, 8).Value = "İşlem Tipi";
        worksheet.Cell(1, 9).Value = "Açıklama";
        
        var headerRange = worksheet.Range(1, 1, 1, 9);
        headerRange.Style.Font.Bold = true;
        headerRange.Style.Fill.BackgroundColor = XLColor.LightCoral;
        
        int row = 2;
        foreach (var trans in transactions.OrderByDescending(t => t.Tarih))
        {
            worksheet.Cell(row, 1).Value = trans.Id;
            worksheet.Cell(row, 2).Value = trans.Tarih.ToString("dd.MM.yyyy HH:mm");
            worksheet.Cell(row, 3).Value = trans.MusteriId;
            worksheet.Cell(row, 4).Value = trans.Malzeme;
            worksheet.Cell(row, 5).Value = trans.Tutar;
            worksheet.Cell(row, 6).Value = trans.Alinan;
            worksheet.Cell(row, 7).Value = trans.Verilen;
            worksheet.Cell(row, 8).Value = trans.IslemTipi.ToString();
            worksheet.Cell(row, 9).Value = trans.Aciklama;
            row++;
        }
        
        worksheet.Columns().AdjustToContents();
        workbook.SaveAs(filePath);
        
        return filePath;
    }
}

