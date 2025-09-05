using Core.Interfaces;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Infrastructure.Helpers
{
    public class ClsGeneral : IGeneralHelper
    {
        private readonly ILogger<ClsGeneral> _logger;

        public ClsGeneral(ILogger<ClsGeneral> logger)
        {
            _logger = logger;
        }

        public string GenerateTransactionNumber()
        {
            try
            {
                var timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmss");
                var random = new Random().Next(1000, 9999);
                var transactionNumber = $"TXN{timestamp}{random}";
                
                _logger.LogDebug("Generated transaction number: {TransactionNumber}", transactionNumber);
                return transactionNumber;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating transaction number");
                throw;
            }
        }

        public string HashPassword(string password)
        {
            try
            {
                using var sha256 = SHA256.Create();
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var hash = Convert.ToBase64String(hashedBytes);
                
                _logger.LogDebug("Password hashed successfully");
                return hash;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error hashing password");
                throw;
            }
        }

        public bool VerifyPassword(string password, string hash)
        {
            try
            {
                var hashedPassword = HashPassword(password);
                var isValid = hashedPassword == hash;
                
                _logger.LogDebug("Password verification result: {IsValid}", isValid);
                return isValid;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error verifying password");
                return false;
            }
        }

        public string GenerateRandomString(int length)
        {
            try
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var random = new Random();
                var result = new string(Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                
                _logger.LogDebug("Generated random string of length: {Length}", length);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating random string");
                throw;
            }
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(email))
                    return false;

                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
                var isValid = emailRegex.IsMatch(email);
                
                _logger.LogDebug("Email validation result for {Email}: {IsValid}", email, isValid);
                return isValid;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error validating email: {Email}", email);
                return false;
            }
        }

        public DateTime ConvertToUtc(DateTime dateTime)
        {
            try
            {
                if (dateTime.Kind == DateTimeKind.Utc)
                    return dateTime;

                var utcDateTime = dateTime.ToUniversalTime();
                _logger.LogDebug("Converted {DateTime} to UTC: {UtcDateTime}", dateTime, utcDateTime);
                return utcDateTime;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error converting datetime to UTC: {DateTime}", dateTime);
                throw;
            }
        }

        public string FormatCurrency(decimal amount)
        {
            try
            {
                var formatted = amount.ToString("C2");
                _logger.LogDebug("Formatted currency: {Amount} -> {Formatted}", amount, formatted);
                return formatted;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error formatting currency: {Amount}", amount);
                return amount.ToString();
            }
        }
    }
}
