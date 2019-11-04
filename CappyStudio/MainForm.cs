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
            file.MenuItems.Add("Open Project");
            file.MenuItems.Add("Save Project");
            file.MenuItems.Add("Build Project");
            file.MenuItems.Add("Exit");
        }
    }
}
