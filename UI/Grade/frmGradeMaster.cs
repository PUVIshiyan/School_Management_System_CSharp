using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_management_system.UI.Grade
{
    public partial class frmGradeMaster : Form
    {
        public frmGradeMaster()
        {
            InitializeComponent();
        }
        Boolean is_addNew=false;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);

        }

        private void ButtonEnable(bool is_true)
        {
            is_addNew = is_true;
            btnAdd.Enabled = !is_true;
            btnEdit.Enabled = !is_true;
            btnDelete.Enabled = !is_true;
            btnRefresh.Enabled = !is_true;
            btnExit.Enabled = !is_true;

            btnSave.Enabled = is_true;
            btnCancel.Enabled = is_true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonEnable(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
            is_addNew=false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (is_addNew)
            {
                DAL.GradeDal.insert(txtName.Text.Trim(), txtOrder.Text.Trim(), txtColor.Text.Trim());
                MessageBox.Show("Save success fully!!!");
                DataTable dt = DAL.GradeDal.GetAll();
                grvGrade.DataSource = dt;
                txtName.Text=null;
                txtOrder.Text=null;
                txtColor.Text=null;
                txtGroup.Text=null;
            }
            else
            {
                 
            }
            ButtonEnable(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //delete function
            }
        }

        private void frmGradeMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = DAL.GradeDal.GetAll();
            grvGrade.DataSource = dt;
        }
    }
}
