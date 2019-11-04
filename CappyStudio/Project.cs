using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CappyStudio
{
    static class Project
    {
        private static List<string> interactions = new List<string>();

        public static string[] ParseInteractions()
        {
            // instantiate the file for reading
            string projContent = File.ReadAllText(Studio.ProjectPath);

            // remove the last ? from the file (always the last byte), because it is used to separate scriptItems. leaving this in would be catastrophic, but there's probably a better way.
            projContent = projContent.Remove(projContent.Length - 1);

            // now that there is a ? between each scriptItem, and not at the start or ends, we can properly index them all in an array
            string[] items = projContent.Split('?');

            return items;
        }

        public static string[] GetInteraction(int index)
        {
            // get interaction in file at this index
            string content = ParseInteractions()[index];

            // put all items from this interaction into a string array
            string[] items = content.Split(';');

            // return it
            return items;
        }

        public static void SetInteraction(int interaction, int index)
        {
            string intr;
        }

        public static void InitList()
        {
            foreach(var item in ParseInteractions())
            {
                interactions.Add(item);
            }
        }
    }
}
