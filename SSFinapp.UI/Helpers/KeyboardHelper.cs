namespace SSFinapp.UI.Helpers;

/// <summary>
/// Klavye kısayolları için helper sınıfı
/// </summary>
public static class KeyboardHelper
{
    /// <summary>
    /// Form'a standart klavye kısayollarını ekler
    /// </summary>
    public static void SetupKeyboardShortcuts(Form form, Action? onInsert = null, Action? onDelete = null, 
        Action? onEnter = null, Action? onF5 = null, Action? onF3 = null, Action? onEscape = null)
    {
        form.KeyPreview = true;
        form.KeyDown += (sender, e) =>
        {
            // ESC: Kapat/İptal
            if (e.KeyCode == Keys.Escape && onEscape != null)
            {
                e.Handled = true;
                onEscape();
            }
            // INS: Yeni kayıt
            else if (e.KeyCode == Keys.Insert && onInsert != null)
            {
                e.Handled = true;
                onInsert();
            }
            // DEL: Sil
            else if (e.KeyCode == Keys.Delete && onDelete != null)
            {
                e.Handled = true;
                onDelete();
            }
            // ENTER: Kaydet (Ctrl+Enter veya sadece Enter - form'a göre)
            else if (e.KeyCode == Keys.Enter && !e.Control && !e.Alt && !e.Shift && onEnter != null)
            {
                // Eğer aktif kontrol bir TextBox, ComboBox veya MaterialTextBox ise, Enter'ı işleme
                var activeControl = form.ActiveControl;
                if (activeControl is TextBox || activeControl is ComboBox || 
                    activeControl?.GetType().Name.Contains("MaterialTextBox") == true ||
                    activeControl?.GetType().Name.Contains("MaterialComboBox") == true)
                {
                    // Multiline TextBox'larda Enter normal davranış
                    if (activeControl is TextBox txt && txt.Multiline)
                        return;
                    // MaterialMultiLineTextBox'larda da Enter normal davranış
                    if (activeControl?.GetType().Name.Contains("MaterialMultiLineTextBox") == true)
                        return;
                    return;
                }
                e.Handled = true;
                onEnter();
            }
            // F5: Yenile
            else if (e.KeyCode == Keys.F5 && onF5 != null)
            {
                e.Handled = true;
                onF5();
            }
            // F3: Ara
            else if (e.KeyCode == Keys.F3 && onF3 != null)
            {
                e.Handled = true;
                onF3();
            }
        };
    }
}

