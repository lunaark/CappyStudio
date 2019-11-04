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
        // fields
        private int index = 0;
        private int maxLength = 0;

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
            file.MenuItems.Add("Close Project", new EventHandler(CloseProject));
            file.MenuItems.Add("Build Project", new EventHandler(BuildProject));
            file.MenuItems.Add("Exit", new EventHandler(ExitApp));

            Initialize();
        }

        private void Initialize()
        {
            // initialize ui
            btnModify.Visible = false;

            btnLeft.Text = char.ConvertFromUtf32(0x2190);
            btnRight.Text = char.ConvertFromUtf32(0x2192);

            picDisplay.Image = ImageMethods.ResizeImage(Properties.Resources.grid, picDisplay.Width, picDisplay.Height);

            index = 0;
            maxLength = 0;

            lblAction.Text = "";
            lblIndex.Text = "";
            lblKeyPress.Text = "";
        }

        private void RefreshInteraction()
        {
            // set index label
            lblIndex.Text = $"Current Index: {index+1} of {maxLength}";

            // split interactions
            string[] items = Project.GetInteraction(index);

            // prepare fields
            string ButtonClicked = String.Empty;
            string WindowText = String.Empty;
            string FullFileName = String.Empty;

            // declare them
            if (items.Length == 4)
            {
                ButtonClicked = items[0];
                WindowText = items[1];
                FullFileName = items[2];

                if(String.IsNullOrEmpty(WindowText))
                {
                    WindowText = "Unknown";
                }
                lblAction.Text = $"Interaction: {WindowText}";
            }
            else if(items.Length == 2)
            {
                ButtonClicked = items[0];
                FullFileName = items[1];
            }

            // set more gui stuff
            lblKeyPress.Text = $"Button Clicked: {ButtonClicked}";
            picDisplay.Image.Dispose();
            picDisplay.Image = ImageMethods.ResizeImage(Image.FromFile(FullFileName), picDisplay.Width, picDisplay.Height);
        }

        private void OpenProject(object sender, EventArgs e)
        {
            using(OpenFileDialog projDialog = new OpenFileDialog())
            {
                if(projDialog.ShowDialog() == DialogResult.OK)
                {
                    Studio.ProjectPath = projDialog.FileName;

                    maxLength = Project.ParseInteractions().Length;

                    btnModify.Visible = true;

                    RefreshInteraction();
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

        private void CloseProject(object sender, EventArgs e)
        {
            Initialize();
            Studio.ProjectPath = String.Empty;
        }

        private void BuildProject(object sender, EventArgs e)
        {
        }

        private void ExitApp(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if(index >= 1)
            {
                index--;
                RefreshInteraction();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if(index < maxLength-1)
            {
                index++;
                RefreshInteraction();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            EditorForm elementEditor = new EditorForm();
            elementEditor.Show();
        }
    }
}
