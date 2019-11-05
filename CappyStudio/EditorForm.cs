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
        }

        private void LoadElement()
        {
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

            btnFocus.Visible = true;
            btnFull.Visible = true;
        }

        private void KeyCapture()
        {
            ButtonClicked = contents[0];
            FullFileName = contents[1];

            btnFocus.Visible = false;
            btnFull.Visible = true;

            txtInteraction.Text = WindowText;
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
    }
}
