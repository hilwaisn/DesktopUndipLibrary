using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace DesktopUndipLibrary.View
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Contiue or not", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit();
            FormMain main = new FormMain();
            main.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.Show();
            this.Hide();
        }

        private void btnVisitors_Click(object sender, EventArgs e)
        {
            FormVisitors visitors = new FormVisitors();
            visitors.Show();
            this.Hide();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            FormMember member = new FormMember();
            member.Show();
            this.Hide();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            FormBook book = new FormBook();
            book.Show();
            this.Hide();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            FormTransaction transaction = new FormTransaction();
            transaction.Show();
            this.Hide();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
