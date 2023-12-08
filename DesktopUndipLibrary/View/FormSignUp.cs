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
    public partial class FormSignUp : Form
    {
        AdminController adminControl;
        public FormSignUp()
        {
            adminControl = new AdminController();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBoxClosedEyes.Visible = true;
            pictureBoxEyesOpen.Visible = false;
            txtUsername.MaxLength = 10;
            txtPassword.MaxLength = 10;
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AdminController admController = new AdminController();
            ValidasiController val = new ValidasiController();
            if (verify())
            {
                if (val.valUsername(txtUsername.Text))
                {
                    admController.addedAdmin(txtUsername.Text, txtPassword.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    txtUsername.Focus();
                    MessageBox.Show("Data Saved");
                    DesktopUndipLibrary.FormSign ad = new DesktopUndipLibrary.FormSign();

                    ad.Show();
                    this.Hide();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormSign ba = new FormSign();
            ba.Show();
            this.Hide();
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
