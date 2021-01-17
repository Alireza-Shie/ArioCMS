using System;
using System.Globalization;

namespace Ario.CMS.Utility
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime dateTime)
        {
            PersianCalendar persianCalendar = new PersianCalendar();

            string shamsiDate = persianCalendar.GetYear(dateTime).ToString() + "/" +
                                persianCalendar.GetMonth(dateTime).ToString("00") + "/" +
                                persianCalendar.GetDayOfMonth(dateTime).ToString("00");

            return shamsiDate;
        }
    }
}