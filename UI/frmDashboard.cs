using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_management_system.UI
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void sudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Student.frmStudentMaster f = new Student.frmStudentMaster();
            f.MdiParent = this;
            f.Show();

        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Subject.frmSubjectMaster f= new Subject.frmSubjectMaster();
            f.MdiParent = this;
            f.Show();
        }

        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Grade.frmGradeMaster f=new Grade.frmGradeMaster();
            f.MdiParent = this;
            f.Show();
        }
    }
}
