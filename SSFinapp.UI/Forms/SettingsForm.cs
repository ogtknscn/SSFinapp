using MaterialSkin;
using MaterialSkin.Controls;
using SSFinapp.UI.Helpers;

namespace SSFinapp.UI.Forms;

/// <summary>
/// Ayarlar formu - Tema değiştirme
/// </summary>
public partial class SettingsForm : MaterialForm
{
    public SettingsForm()
    {
        InitializeComponent();
        LoadCurrentSettings();
    }
    
    private void LoadCurrentSettings()
    {
        var currentTheme = ThemeHelper.LoadTheme();
        rdbLight.Checked = currentTheme == MaterialSkinManager.Themes.LIGHT;
        rdbDark.Checked = currentTheme == MaterialSkinManager.Themes.DARK;
    }
    
    private void btnSave_Click(object sender, EventArgs e)
    {
        var selectedTheme = rdbDark.Checked 
            ? MaterialSkinManager.Themes.DARK 
            : MaterialSkinManager.Themes.LIGHT;
        
        ThemeHelper.SaveTheme(selectedTheme);
        ThemeHelper.ApplyThemeToAllForms(selectedTheme);
        
        MessageBox.Show(
            "Tema ayarı kaydedildi. Değişiklikler uygulandı.",
            "Başarılı",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
    
    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}

