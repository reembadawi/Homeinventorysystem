using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.Enums;
using WindowsFormsApp8.Entities;
using WindowsFormsApp8.DataAccessLayer;

namespace WindowsFormsApp8.GUI
{
    public partial class frmShoppingiteams : Form
    {
        FormState frmState =FormState.Add;
        Item currentItem = new Item();
        public frmShoppingiteams()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmShoppingiteams_Load(object sender, EventArgs e)
        {
            SetFormState();
            RefreshItemgrid();
        }

        private static void RefreshItemgrid()
        {
            dataGridViewItems.DataSource = IteamsDAL.GetAllItems();
        }

        private void SetFormState()
        {
          if (frmState == FormState.Add)
            {
                btnAdd.Enabled = true;
                btnsave.Enabled = false; 
                btndelete.Enabled = false;
                btncancel.Enabled = false;

            }
          else if (frmState == FormState.WaitingToSave)
            {
                btnAdd.Enabled = false;
                btnsave.Enabled = true;
                btndelete.Enabled = false;
                btncancel.Enabled = true;

            }
          else if (frmState == FormState.WaitingToSaveOrDelete)
            {
                btnAdd.Enabled = false;
                btnsave.Enabled = true;
                btndelete.Enabled = true;
                btncancel.Enabled = true;
            }
            txtname.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmState=FormState.WaitingToSave;
            SetFormState();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            frmState = FormState.Add;
            SetFormState();
            currentItem.ItemName= txtname.Text;
            currentItem.ItemUnit = txtunit.Text;
            currentItem.Quntity = double.Parse(txtq.Text);
            currentItem.UserId = 1;
      IteamsDAL.CreateItem(currentItem);
            ClearForm();
            RefreshItemgrid();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            frmState = FormState.Add;
            SetFormState();
            ClearForm();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            frmState = FormState.Add;
            SetFormState();
            ClearForm();
        }

        private void ClearForm()
        {
            txtname.Text = "";
            txtunit.Text = "";
            txtq.Text = "";
            txtname.Focus();
        }
    }
}
