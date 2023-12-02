using DesktopUndipLibrary.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUndipLibrary
{
    public partial class FormSign : Form
    {
        public FormSign()
        {
            InitializeComponent();
        }

        private void FormSign_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp up = new FormSignUp();
            up.Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            FormSignIn up = new FormSignIn();
            up.Show();
            this.Hide();
        }
    }
}
