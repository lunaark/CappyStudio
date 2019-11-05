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

        public static List<string> Interactions
        {
            get
            {
                return interactions;
            }
            set
            {
                interactions = value;
            }
        }

        public static bool IsLoaded
        { get; set; }

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
            string content = interactions[index];

            // put all items from this interaction into a string array
            string[] items = content.Split(';');

            // return it
            return items;
        }

        public static void SetInteraction(int interaction, int index, string value)
        {
            // declare a string that contains the interaction we want
            string[] interact = GetInteraction(interaction);

            // set that a value inside that interaction to the passed value
            interact[index] = value;

            // recombine them and then ship em back off
            interactions[interaction] = String.Join(";", interact);
        }

        public static void InitList()
        {
            interactions.Clear();
            foreach(var item in ParseInteractions())
            {
                interactions.Add(item);
            }
        }
    }
}
