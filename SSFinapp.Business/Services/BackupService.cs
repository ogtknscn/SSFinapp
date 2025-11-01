namespace SSFinapp.Business.Services;

public class BackupService : IBackupService
{
    private const string DatabaseFileName = "ssfinapp.db";
    
    public async Task<string> CreateBackupAsync(string backupPath)
    {
        var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        var backupFileName = $"backup_{timestamp}.db";
        var fullBackupPath = Path.Combine(backupPath, backupFileName);
        
        if (File.Exists(DatabaseFileName))
        {
            await Task.Run(() => File.Copy(DatabaseFileName, fullBackupPath, true));
            return fullBackupPath;
        }
        
        throw new FileNotFoundException("Veritabanı dosyası bulunamadı!");
    }
    
    public async Task RestoreBackupAsync(string backupFilePath)
    {
        if (!File.Exists(backupFilePath))
            throw new FileNotFoundException("Yedek dosyası bulunamadı!");
            
        await Task.Run(() => File.Copy(backupFilePath, DatabaseFileName, true));
    }
}

