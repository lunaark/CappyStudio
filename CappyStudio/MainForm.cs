using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CappyStudio
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // initialize navigation bar, i'd do this in the designer but i really don't know how.
            Menu = new MainMenu();

            // declare menu items
            MenuItem file = new MenuItem("File");
            MenuItem options = new MenuItem("Options");

            // add items
            Menu.MenuItems.Add(file);
            Menu.MenuItems.Add(options);

            // add sub-items
            file.MenuItems.Add("Open Project", new EventHandler(OpenProject));
            file.MenuItems.Add("Save Project", new EventHandler(SaveProject));
            file.MenuItems.Add("Build Project", new EventHandler(BuildProject));
            file.MenuItems.Add("Exit", new EventHandler(ExitApp));

            // initialize ui
            lblAction.Visible = false;
            lblIndex.Visible = false;
            lblKeyPress.Visible = false;

            btnModify.Visible = false;
        }

        private static string[] ParseProject()
        {
            // instantiate the file for reading
            string projContent = File.ReadAllText(Studio.ProjectPath);

            // remove the last ? from the file (always the last byte), because it is used to separate scriptItems. leaving this in would be catastrophic, but there's probably a better way.
            projContent = projContent.Remove(projContent.Length - 1);

            // now that there is a ? between each scriptItem, and not at the start or ends, we can properly index them all in an array
            string[] items = projContent.Split('?');

            return items;
        }

        private void OpenProject(object sender, EventArgs e)
        {
            using(OpenFileDialog projDialog = new OpenFileDialog())
            {
                if(projDialog.ShowDialog() == DialogResult.OK)
                {
                    Studio.ProjectPath = projDialog.FileName;
                }
            }
        }
        private void SaveProject(object sender, EventArgs e)
        {
            using(StreamWriter projWriter = new StreamWriter(File.Open(Studio.ProjectPath, FileMode.Create)))
            {
                // TODO: add project writer   
            }
        }
        private void BuildProject(object sender, EventArgs e)
        {
        }
        private void ExitApp(object sender, EventArgs e)
        {
        }
    }
}
