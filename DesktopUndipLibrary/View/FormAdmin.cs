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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopUndipLibrary.View
{
    public partial class FormAdmin : Form
    {
        private AdminController adminControl;
        public FormAdmin()
        {
            adminControl = new AdminController();
            InitializeComponent();
            showAdmin();
        }
        bool showAdmin()
        {
            dataGridViewAdmin.DataSource = adminControl.selectAdmin
                (new MySqlConnector.MySqlCommand("SELECT * FROM Admin"));
            dataGridViewAdmin.RowTemplate.Height = 20;
            return true;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            showAdmin();
        }

        bool verify()
        {
            if ((txtUsername.Text == "") || (txtPassword.Text == ""))
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
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    adminControl.deleteAdmin(txtPassword.Text);
                    showAdmin();
                    btnClear.PerformClick();
                    MessageBox.Show("Successfully Deleted Data", "Delete Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain(); 
            main.Show();
            this.Hide();
        }
        private void btnVisitors_Click(object sender, EventArgs e)
        {
            FormVisitors vi = new FormVisitors();
            vi.Show();
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

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dataGridViewAdmin.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = dataGridViewAdmin.CurrentRow.Cells[1].Value.ToString();
        }
    }
}