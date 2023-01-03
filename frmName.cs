using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.GUI;

namespace WindowsFormsApp8
{
    public partial class frmName : Form
    {
        private Form currentActiveForm = null;
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

        private void treeViewnavigation_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Form frm = null;

           TreeNode node= e.Node;

            if (node.Name == "NodeUserProfile")
                frm = new frmUserprofile();
            else if (node.Name == "Node2ShoppingIteams")
                frm = new frmShoppingiteams();
            else if (node.Name == "Node3MyInventory")
                frm = new frmMyinventory();
            else if (node.Name == "Node4StatisticsAndCharts")
                frm = new frmStatistics_And_Charts();



            if(frm !=null)
            {
                if(currentActiveForm != null && currentActiveForm != frm)
                {
                    currentActiveForm.Close();
                    panelcontent.Controls.Remove(currentActiveForm);    
                }
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.TopLevel = false;
                frm.Dock=DockStyle.Fill;

                frm.BackColor = Color.White;
                currentActiveForm=frm;

                panelcontent.Controls.Add(frm);
                frm.Show();


            }

            
        }
    }
}
