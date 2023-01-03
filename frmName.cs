using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class frmName : Form
    {
        public frmName()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit this application ";
            string title = "Exit Application";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result =MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            Application.Exit(); 
        }

        private void frmName_Load(object sender, EventArgs e)
        {
            treeViewnavigation.ExpandAll();   
        }
    }
}
