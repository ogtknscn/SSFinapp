using SSFinapp.Domain.Exceptions;

namespace SSFinapp.UI.Helpers;

/// <summary>
/// UI yardımcı metodlar
/// </summary>
public static class UIHelper
{
    /// <summary>
    /// Async işlem sırasında loading göster ve hata yönet
    /// </summary>
    public static async Task ExecuteWithLoadingAsync(
        Form form,
        Func<Task> action,
        string? successMessage = null)
    {
        form.Cursor = Cursors.WaitCursor;
        form.Enabled = false;
        
        try
        {
            await action();
            
            if (!string.IsNullOrEmpty(successMessage))
            {
                MessageBox.Show(successMessage, "Başarılı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (ValidationException ex)
        {
            MessageBox.Show(ex.Message, "Validasyon Hatası", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (InsufficientStockException ex)
        {
            MessageBox.Show(
                $"{ex.Message}\n\nGerekli: {ex.RequiredAmount:N2}\nMevcut: {ex.AvailableAmount:N2}", 
                "Yetersiz Stok", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (CannotDeleteException ex)
        {
            MessageBox.Show(ex.Message, "Silme Hatası", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Beklenmeyen bir hata oluştu:\n{ex.Message}", 
                "Hata", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            form.Cursor = Cursors.Default;
            form.Enabled = true;
        }
    }
    
    /// <summary>
    /// Onay sorusu
    /// </summary>
    public static bool ConfirmAction(string message, string title = "Onay")
    {
        var result = MessageBox.Show(message, title, 
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        return result == DialogResult.Yes;
    }
    
    /// <summary>
    /// Başarı mesajı (kısa gösterim)
    /// </summary>
    public static void ShowSuccess(string message)
    {
        MessageBox.Show(message, "Başarılı", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    
    /// <summary>
    /// Hata mesajı
    /// </summary>
    public static void ShowError(string message)
    {
        MessageBox.Show(message, "Hata", 
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    
    /// <summary>
    /// Uyarı mesajı
    /// </summary>
    public static void ShowWarning(string message)
    {
        MessageBox.Show(message, "Uyarı", 
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}

