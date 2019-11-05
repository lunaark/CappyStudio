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
            if (contents.Length == 4)
            {
                MouseCapture();
            }
            else if (contents.Length == 2)
            {
                KeyCapture();
            }
            txtAction.Text = ButtonClicked;
        }

        private void MouseCapture()
        {
            ButtonClicked = contents[0];
            WindowText = contents[1];
            FullFileName = contents[2];
            FocusFileName = contents[3];

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

            txtAction.Text = ButtonClicked;
            txtInteraction.Text = WindowText;
        }

        private void KeyCapture()
        {
            ButtonClicked = contents[0];
            FullFileName = contents[1];

            btnFocus.Visible = false;
            btnFull.Visible = true;

            txtInteraction.Visible = false;
            lblInteraction.Visible = false;

            btnFull.Text = "Choose Screenshot";

            txtInteraction.Text = WindowText;
        }

        private void SaveChanges()
        {
            if (contents.Length == 4)
            {
                Project.SetInteraction(Studio.Index, 0, txtAction.Text);
                Project.SetInteraction(Studio.Index, 1, txtInteraction.Text);
                Project.SetInteraction(Studio.Index, 2, FullFileName);
                Project.SetInteraction(Studio.Index, 3, FocusFileName);
            }
            else if (contents.Length == 2)
            {
                Project.SetInteraction(Studio.Index, 0, txtAction.Text);
                Project.SetInteraction(Studio.Index, 1, FullFileName);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Studio.Index < Studio.MaxLength - 1)
            {
                Studio.Index++;
                LoadElement();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (Studio.Index >= 1)
            {
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
            using(OpenFileDialog fullDialog = new OpenFileDialog())
            {
                if(fullDialog.ShowDialog() == DialogResult.OK)
                {
                    FullFileName = fullDialog.FileName;
                }
            }
        }

        private void btnFocus_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog focusDialog = new OpenFileDialog())
            {
                if (focusDialog.ShowDialog() == DialogResult.OK)
                {
                    FocusFileName = focusDialog.FileName;
                }
            }
        }
    }
}
