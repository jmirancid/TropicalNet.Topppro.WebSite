using System;
using System.Globalization;

namespace Topppro.Context
{
    public class Current
    {
        public static DateTime GetNowUTC
        {
            get
            {
                return DateTime.UtcNow;
            }
        }

        public static CultureInfo Culture
        {
            get
            {
                return System.Threading.Thread.CurrentThread.CurrentCulture;
            }

            set
            {
                System.Threading.Thread.CurrentThread.CurrentCulture =
                System.Threading.Thread.CurrentThread.CurrentUICulture = value;
            }
        }

        private static Topppro.Entities.Region_Enum region;

        public static Topppro.Entities.Region_Enum Region
        {
            get { return region; }
            set { region = value; }
        }
    }
}
