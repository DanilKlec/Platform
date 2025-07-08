using Microsoft.Extensions.Logging;
using System.Globalization;
using System.Text;

namespace ISCore.Queries
{
    public class BaseQuery
    {
        private readonly ILogger<BaseQuery> _logger;

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public DateTime DateTimeToLocalTime(string originalString)
        {
            try
            {
                string subString = originalString.Substring(originalString.IndexOf("("));
                subString = subString.Substring(0, subString.IndexOf(")"));
                subString = subString.Remove(0, 1);
                var epochString = subString;

                epochString = epochString.Substring(0, epochString.Length - 5);

                DateTimeOffset dateTimeOffset2 = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(epochString));

                DateTime dateTime = dateTimeOffset2.DateTime;

                return dateTime.ToLocalTime();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, ex.Message);
                return DateTime.MinValue;
            }
        }

        public string NumberBeautify(float number)
        {
            try
            {
                var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                nfi.NumberGroupSeparator = " ";
                string formatted = number.ToString("#,0.00", nfi); // "1 234 897.11"

                return formatted;
            }
            catch (Exception ex)
            {
                return number.ToString();
            }
        }

        public string DecimalBeautify(decimal number)
        {
            try
            {
                var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                nfi.NumberGroupSeparator = " ";
                string formatted = number.ToString("#,0.00", nfi); // "1 234 897.11"

                return formatted;
            }
            catch (Exception ex)
            {
                return number.ToString();
            }
        }

        public string FloatBeautify(float number)
        {
            try
            {
                var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                nfi.NumberGroupSeparator = " ";
                string formatted = number.ToString("#,0.00", nfi); // "1 234 897.11"

                return formatted;
            }
            catch (Exception ex)
            {
                return number.ToString();
            }
        }

        public string DecimalQuantityBeautify(decimal number)
        {
            try
            {
                var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                nfi.NumberGroupSeparator = " ";
                string formatted = number.ToString("#,0.000", nfi); // "1 234 897.11"

                return formatted;
            }
            catch (Exception ex)
            {
                return number.ToString();
            }
        }

        public string QuantityBeautify(float number)
        {
            try
            {
                var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                nfi.NumberGroupSeparator = " ";
                string formatted = number.ToString("#,0.000", nfi); // "1 234 897.11"

                return formatted;
            }
            catch (Exception ex)
            {
                return number.ToString();
            }
        }
    }
}
