using System;
using System.Globalization;

namespace TimeElapsedCounter
{
    public static class UtilsConverter
    {
        public const string ShortDateFormat = "dd/MM/yyyy";

        public static DateTime ToDateTime(this string valueToParse)
        {
            try
            {
                DateTime.TryParseExact(valueToParse, ShortDateFormat, null, DateTimeStyles.None, out DateTime datetime);
                return datetime;
            }
            catch
            {
                throw new Exception($"No se pudo convertir a fecha el objeto {valueToParse.ToString()}");
            }
        }

        public static string ToStringNotEmpty(this string stringToEvaluate)
        {
            string value= string .Empty;
            if(!string.IsNullOrWhiteSpace(stringToEvaluate))
            {
                return stringToEvaluate;
            }

            return value;
        }
    }
}
