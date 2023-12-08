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
using System.Xml.Linq;

namespace DesktopUndipLibrary.View
{
    public partial class FormSignIn : Form
    {
        AdminController adminControl;
        public FormSignIn()
        {
            adminControl = new AdminController();
            InitializeComponent();
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
            pictureBoxEyesOpen.Visible = false;
            pictureBoxClosedEyes.Visible = true;
            txtUsername.MaxLength = 10;
            txtPassword.MaxLength = 10;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormSign ba = new FormSign();
            ba.Show();
            this.Hide();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidasiController val = new ValidasiController();
            if (verify())
            {
                if (val.valUsername(txtUsername.Text))
                {

                    if ((txtUsername.Text == "") || (txtPassword.Text == ""))
                    {
                        MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string name = txtUsername.Text;
                        string password = txtPassword.Text;
                        DataTable table = adminControl.getList(new MySqlConnector.MySqlCommand
                            ("SELECT * FROM Admin WHERE Username = '" + name + "' AND Passwordd ='" + password + "'"));

                        if (table.Rows.Count > 0)
                        {
                            FormMain main = new FormMain();
                            this.Hide();
                            main.Show();
                        }
                        else
                        {
                            MessageBox.Show("Your admin and password are not exist", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void pictureBoxClosedEyes_Click(object sender, EventArgs e)
        {
            pictureBoxEyesOpen.Visible = true;
            pictureBoxClosedEyes.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pictureBoxEyesOpen_Click(object sender, EventArgs e)
        {
            pictureBoxEyesOpen.Visible = false;
            pictureBoxClosedEyes.Visible = true;
            txtPassword.UseSystemPasswordChar = false;
        }
    }
}
