namespace SSFinapp.Business.Services;

public interface IBackupService
{
    Task<string> CreateBackupAsync(string backupPath);
    Task RestoreBackupAsync(string backupFilePath);
}

