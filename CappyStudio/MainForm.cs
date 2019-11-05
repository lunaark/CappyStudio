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
            file.MenuItems.Add("Close Project", new EventHandler(CloseProject));
            file.MenuItems.Add("Build Project", new EventHandler(BuildProject));
            file.MenuItems.Add("Exit", new EventHandler(ExitApp));

            Initialize();
        }

        private void Initialize()
        {
            // initialize ui
            btnModify.Visible = false;

            btnLeft.Visible = false;
            btnRight.Visible = false;

            picDisplay.Visible = false;

            btnLeft.Text = char.ConvertFromUtf32(0x2190);
            btnRight.Text = char.ConvertFromUtf32(0x2192);

            Studio.Index = 0;
            Studio.MaxLength = 0;

            lblAction.Text = "";
            lblIndex.Text = "";
            lblKeyPress.Text = "";

            picDisplay.Image = Properties.Resources.grid;
        }

        private void ProjectLoad()
        {
            Studio.MaxLength = Project.ParseInteractions().Length;

            btnModify.Visible = true;
            btnLeft.Visible = true;
            btnRight.Visible = true;

            picDisplay.Visible = true;
        }

        private void RefreshInteraction()
        {
            // set index label
            lblIndex.Text = $"Current Index: {Studio.Index+1} of {Studio.MaxLength}";

            // split interactions
            string[] items = Project.GetInteraction(Studio.Index);

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
                    Project.IsLoaded = true;

                    Project.InitList();
                    ProjectLoad();
                    RefreshInteraction();
                }
            }
        }

        private void SaveProject(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter projWriter = new StreamWriter(File.Open(Studio.ProjectPath, FileMode.Create)))
                {
                    // TODO: add project writer
                    projWriter.Write(String.Join("?", Project.Interactions.ToArray()));
                }
            }
            catch(IOException)
            {
                MessageBox.Show("Insufficient permissions!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseProject(object sender, EventArgs e)
        {
            if (Project.IsLoaded)
            {
                Initialize();

                Studio.ProjectPath = String.Empty;
                Project.IsLoaded = false;
            }
            else
            {
                MessageBox.Show("No project is loaded!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if(Studio.Index >= 1)
            {
                Studio.Index--;
                RefreshInteraction();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if(Studio.Index < Studio.MaxLength- 1)
            {
                Studio.Index++;
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
