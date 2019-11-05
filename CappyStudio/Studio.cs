using System;
using System.Collections.Generic;
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
    }
}
