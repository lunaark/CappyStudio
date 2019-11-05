using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CappyStudio
{
    public partial class EditorForm : Form
    {
        string[] contents = Project.GetInteraction(Studio.Index);

        string ButtonAction = String.Empty;
        string ButtonClicked = String.Empty;
        string WindowText = String.Empty;
        string FullFileName = String.Empty;
        string FocusFileName = String.Empty;

        public EditorForm()
        {
            InitializeComponent();
            LoadElement();

            FormClosing += new FormClosingEventHandler(EditorClosing);
        }

        private void LoadElement()
        {
            contents = Project.GetInteraction(Studio.Index);

            lblIndex.Text = $"Index: {Studio.Index + 1} of {Studio.MaxLength}";
            if (contents.Length == 5)
            {
                MouseCapture();
            }
            else if (contents.Length == 3)
            {
                KeyCapture();
            }
        }

        private void MouseCapture()
        {
            ButtonAction = contents[0];
            ButtonClicked = contents[1];
            WindowText = contents[2];
            FullFileName = contents[3];
            FocusFileName = contents[4];

            btnFull.Text = "Choose Full Screenshot";
            btnFocus.Text = "Choose Focused Screenshot";

            btnFocus.Visible = true;
            btnFull.Visible = true;

            txtInteraction.Visible = true;
            lblInteraction.Visible = true;

            if (String.IsNullOrEmpty(WindowText))
            {
                WindowText = "Unknown";
            }

            txtAction.Text = ButtonAction;
            txtBtnClicked.Text = ButtonClicked;
            txtInteraction.Text = WindowText;
        }

        private void KeyCapture()
        {
            ButtonAction = contents[0];
            ButtonClicked = contents[1];
            FullFileName = contents[2];

            btnFocus.Visible = false;
            btnFull.Visible = true;

            txtInteraction.Visible = false;
            lblInteraction.Visible = false;

            btnFull.Text = "Choose Screenshot";

            txtAction.Text = ButtonAction;
            txtBtnClicked.Text = ButtonClicked;
            txtInteraction.Text = WindowText;
        }

        private void SaveChanges()
        {
            if (contents.Length == 5)
            {
                Project.SetInteraction(Studio.Index, 0, txtAction.Text);
                Project.SetInteraction(Studio.Index, 1, txtBtnClicked.Text);
                Project.SetInteraction(Studio.Index, 2, txtInteraction.Text);
                Project.SetInteraction(Studio.Index, 3, FullFileName);
                Project.SetInteraction(Studio.Index, 4, FocusFileName);
            }
            else if (contents.Length == 3)
            {
                Project.SetInteraction(Studio.Index, 0, txtAction.Text);
                Project.SetInteraction(Studio.Index, 1, txtBtnClicked.Text);
                Project.SetInteraction(Studio.Index, 2, FullFileName);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Studio.Index < Studio.MaxLength - 1)
            {
                SaveChanges();
                Studio.Index++;
                LoadElement();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (Studio.Index >= 1)
            {
                SaveChanges();
                Studio.Index--;
                LoadElement();
            }
        }

        private void EditorClosing(object sender, FormClosingEventArgs e)
        {
            SaveChanges();
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fullDialog = new OpenFileDialog())
            {
                fullDialog.Filter = "Image files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
                fullDialog.Title = "Select an Image";
                if (fullDialog.ShowDialog() == DialogResult.OK)
                {
                    FullFileName = fullDialog.FileName;
                }
            }
        }

        private void btnFocus_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog focusDialog = new OpenFileDialog())
            {
                focusDialog.Filter = "Image files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
                focusDialog.Title = "Select an Image";
                if (focusDialog.ShowDialog() == DialogResult.OK)
                {
                    FocusFileName = focusDialog.FileName;
                }
            }
        }
    }
}
