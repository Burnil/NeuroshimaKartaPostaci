using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neuroshima
{
    public partial class Manager : Form
    {
        public static Manager Form1Instance;
        public Manager()
        {
            
            Form1Instance = this;

            //Make sure I am kept hidden
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = false;

            InitializeComponent();

            //Open a managed form - the one the user sees..
            var infoFillWindow = new MainWindow();
            infoFillWindow.Show();
        }
    }
}
