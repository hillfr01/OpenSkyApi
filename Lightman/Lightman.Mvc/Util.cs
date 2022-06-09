namespace Lightman.Mvc
{
    public static class Util
    {
        public static long DotNetDateTimeToUnixEpochSeconds(DateTime dateTimeIn)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            TimeSpan span1 = TimeZoneInfo.ConvertTimeToUtc(dateTimeIn) - unixStart;
            long unix1 = (long)span1.TotalSeconds;
            return unix1;
        }

        public static DateTime UnixEpochSecondsToDotNetDateTime(long unixEpochSecondsIn)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            DateTime localDatetime = unixStart.AddSeconds(unixEpochSecondsIn).ToLocalTime();
            return localDatetime;
        }

        public static class Constants
        {
            public const string ViewDataKeyForAirportSelect = "AirportSelectListItems";
        }
    }
}
