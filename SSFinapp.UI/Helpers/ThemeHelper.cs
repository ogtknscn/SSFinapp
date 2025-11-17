using MaterialSkin;
using System.Text.Json;

namespace SSFinapp.UI.Helpers;

/// <summary>
/// Tema yönetimi için helper sınıfı
/// </summary>
public static class ThemeHelper
{
    private static readonly string SettingsFilePath = Path.Combine(
        Application.StartupPath, "appsettings.json");
    
    public class AppSettings
    {
        public string Theme { get; set; } = "Light";
    }
    
    /// <summary>
    /// Mevcut tema ayarını yükle
    /// </summary>
    public static MaterialSkinManager.Themes LoadTheme()
    {
        try
        {
            if (File.Exists(SettingsFilePath))
            {
                var json = File.ReadAllText(SettingsFilePath);
                var settings = JsonSerializer.Deserialize<AppSettings>(json);
                
                if (settings?.Theme == "Dark")
                    return MaterialSkinManager.Themes.DARK;
            }
        }
        catch
        {
            // Hata durumunda varsayılan tema
        }
        
        return MaterialSkinManager.Themes.LIGHT;
    }
    
    /// <summary>
    /// Tema ayarını kaydet
    /// </summary>
    public static void SaveTheme(MaterialSkinManager.Themes theme)
    {
        try
        {
            var settings = new AppSettings
            {
                Theme = theme == MaterialSkinManager.Themes.DARK ? "Dark" : "Light"
            };
            
            var json = JsonSerializer.Serialize(settings, new JsonSerializerOptions 
            { 
                WriteIndented = true 
            });
            
            File.WriteAllText(SettingsFilePath, json);
        }
        catch
        {
            // Hata durumunda sessizce devam et
        }
    }
    
    /// <summary>
    /// Tüm açık formlara tema uygula
    /// </summary>
    public static void ApplyThemeToAllForms(MaterialSkinManager.Themes theme)
    {
        var manager = MaterialSkinManager.Instance;
        manager.Theme = theme;
        
        // Color scheme'i tema'ya göre ayarla
        if (theme == MaterialSkinManager.Themes.DARK)
        {
            manager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE);
        }
        else
        {
            manager.ColorScheme = new ColorScheme(
                Primary.Blue700,
                Primary.Blue900,
                Primary.Blue500,
                Accent.Blue200,
                TextShade.WHITE);
        }
        
        // Tüm açık formları güncelle
        foreach (Form form in Application.OpenForms)
        {
            if (form is MaterialSkin.Controls.MaterialForm materialForm)
            {
                manager.AddFormToManage(materialForm);
            }
        }
    }
}

