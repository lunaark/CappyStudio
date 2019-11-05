using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CappyStudio
{
    static class Studio
    {
        // fields
        private static int index = 0;
        private static int maxLength = 0;

        public static int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        public static int MaxLength
        {
            get
            {
                return maxLength;
            }
            set
            {
                maxLength = value;
            }
        }

        public static string ProjectPath { get; set; }

        public static string OutputPath { get; set; }
            
        public static string GetSaveTime()
        {
            // let there be time
            DateTime SaveTime = DateTime.Now;
            CultureInfo deCulture = new CultureInfo("de-DE");

            string FormattedSaveTime = SaveTime.ToString(deCulture);

            // roslynator says this is a redundant assignment, but strings are immutable
            FormattedSaveTime = FormattedSaveTime.Replace(":", ".").Replace(" ", "-");

            return FormattedSaveTime;
        }
    }
}
