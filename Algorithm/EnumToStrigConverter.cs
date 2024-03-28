namespace Algorithm
{
    public static class EnumToStrigConverter
    {
        public static List<string> GetEnumString()
        {
            List<string> list = new List<string>
            {
                Weekday.Monday.ToString(),
                Weekday.Tuesday.ToString(),
                Weekday.Wednesday.ToString(),
                Weekday.Thursday.ToString(),
                Weekday.Friday.ToString(),
                Weekday.Saturday.ToString(),
                Weekday.Sunday.ToString(),
            };
            return list;
        }

        public static string GetDescription<TEnum>(this TEnum value) where TEnum : IComparable, IFormattable, IConvertible
        {
            if (value is Enum)
            {
                return GetDescription(value as Enum);
            }
            else
            {
                return value.ToString();
            }
        }
    }
    public enum Weekday
    {
        Monday = 0, Tuesday = 1, Wednesday = 2,
        Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7
    }


}
