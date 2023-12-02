using DesktopUndipLibrary.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUndipLibrary.View
{
    public partial class FormVisitors : Form
    {
        private VisitorsController visitorsControl;
        public FormVisitors()
        {
            visitorsControl = new VisitorsController();
            InitializeComponent();
            showVisitors();
        }
        bool showVisitors()
        {
            dataGridViewMain.DataSource = visitorsControl.selectVisitors
                (new MySqlConnector.MySqlCommand("SELECT * FROM Visitors"));
            dataGridViewMain.RowTemplate.Height = 100;
            return true;
        }
        private void FormVisitors_Load(object sender, EventArgs e)
        {
            showVisitors();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormSign ba = new FormSign();
            ba.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin ad = new FormAdmin();
            ad.Show();
            this.Hide();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            /*FormMember member = new FormMember();
            member.Show();
            this.Hide();*/
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            FormBook book = new FormBook();
            book.Show();
            this.Hide();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            /*FormTransaction transaction = new FormTransaction();
            transaction.Show();
            this.Hide();*/
        }
        /*
        bool verify()
        {
            if ((txtDeleteUsername.Text == "") || (txtDeletePassword.Text == ""))
            {
                return false;
            }
            else
            {
            return true;
            }
            }

            private void btnClear_Click(object sender, EventArgs e)
            {
            txtDeleteUsername.Clear();
            txtDeletePassword.Clear();
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
            if (verify())
            {
            try
            {
            adminControl.deleteAdmin(txtDeletePassword.Text);
            showAdmin();
            btnClear.PerformClick();
            MessageBox.Show("Successfully Deleted Data", "Delete Data",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDeletePassword.Focus();
            }
            catch (Exception ex)
            {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            else
            {
            MessageBox.Show("Delete Error Data", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }

            private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            txtDeleteUsername.Text = dataGridViewMain.CurrentRow.Cells[0].Value.ToString();
            txtDeletePassword.Text = dataGridViewMain.CurrentRow.Cells[1].Value.ToString();
            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
            FormSign ba = new FormSign();
            ba.Show();
            this.Hide();
            }

            private void btnVisitors_Click(object sender, EventArgs e)
            {
            FormVisitors vi = new FormVisitors();
            vi.Show();
            this.Hide();
            }*/
    }
}
