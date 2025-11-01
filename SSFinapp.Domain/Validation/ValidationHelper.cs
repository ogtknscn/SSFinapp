using System.Text.RegularExpressions;

namespace SSFinapp.Domain.Validation;

/// <summary>
/// Validasyon helper sınıfı
/// </summary>
public static class ValidationHelper
{
    public static bool IsValidEmail(string? email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return true; // Optional field
            
        var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, emailPattern);
    }
    
    public static bool IsValidPhone(string? phone)
    {
        if (string.IsNullOrWhiteSpace(phone))
            return true; // Optional field
            
        // Türkiye telefon formatı: 05XX XXX XX XX veya +90 5XX XXX XX XX
        var cleaned = Regex.Replace(phone, @"[\s\-\(\)]", "");
        
        if (cleaned.StartsWith("+90"))
            cleaned = cleaned.Substring(3);
        else if (cleaned.StartsWith("90"))
            cleaned = cleaned.Substring(2);
            
        return cleaned.Length == 10 && cleaned.StartsWith("5") && cleaned.All(char.IsDigit);
    }
    
    public static string? FormatPhone(string? phone)
    {
        if (string.IsNullOrWhiteSpace(phone))
            return phone;
            
        var cleaned = Regex.Replace(phone, @"[\s\-\(\)]", "");
        
        if (cleaned.StartsWith("+90"))
            cleaned = cleaned.Substring(3);
        else if (cleaned.StartsWith("90"))
            cleaned = cleaned.Substring(2);
            
        if (cleaned.Length == 10)
            return $"0{cleaned.Substring(0, 3)} {cleaned.Substring(3, 3)} {cleaned.Substring(6, 2)} {cleaned.Substring(8, 2)}";
            
        return phone;
    }
    
    public static bool IsPositiveNumber(decimal value)
    {
        return value > 0;
    }
    
    public static bool IsNonNegativeNumber(decimal value)
    {
        return value >= 0;
    }
    
    public static bool IsValidString(string? value, int maxLength)
    {
        if (string.IsNullOrWhiteSpace(value))
            return false;
            
        return value.Trim().Length <= maxLength;
    }
}

