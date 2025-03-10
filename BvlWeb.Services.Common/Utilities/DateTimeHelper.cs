using System;

namespace BvlWeb.Services.Common.Utilities
{
    public static class DateTimeHelper
    {
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }
    }
}
