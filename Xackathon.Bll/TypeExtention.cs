namespace Xackathon.Bll
{
    public static class TypeExtention
    {
        public static string ToFormatString(this DateTime? date)
        {
            if (date == null)
                return null;

            return date.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }
        public static string ToFormatString(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss");
        }
        public static DateTime? ToNullableDateTime(this string stringDate)
        {
            if (stringDate == null)
                return null;

            DateTime date;

            var result = DateTime.TryParseExact(stringDate, "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out date);
           
            if(!result)
                throw new Exception(Resources.Errors.DateNotValid + $": {stringDate}");

            date = DateTime.SpecifyKind(date, DateTimeKind.Utc);

            return date;
        }
        public static DateTime ToDateTime(this string stringDate)
        {
            if (stringDate == null)
                throw new Exception(Resources.Errors.DateNotValid);

            DateTime date;

            var result = DateTime.TryParseExact(stringDate, "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out date);

            if (!result)
                throw new Exception(Resources.Errors.DateNotValid + $": {stringDate}");

            date = DateTime.SpecifyKind(date, DateTimeKind.Utc);

            return date;
        }
    }
}
