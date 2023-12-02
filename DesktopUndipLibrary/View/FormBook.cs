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
    public partial class FormBook : Form
    {
        private BookController bookControl;
        public FormBook()
        {
            bookControl = new BookController();
            InitializeComponent();
            showBook();
        }
        bool showBook()
        {
            dataGridViewMain.DataSource = bookControl.selectBook
                (new MySqlConnector.MySqlCommand("SELECT * FROM Book"));
            dataGridViewMain.RowTemplate.Height = 30;
            return true;
        }
        private void FormBook_Load(object sender, EventArgs e)
        {

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
            /*FormMember member = new FormMember();
            member.Show();
            this.Hide();*/
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            /*FormTransaction transaction = new FormTransaction();
            transaction.Show();
            this.Hide();*/
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnRack_Click(object sender, EventArgs e)
        {

        }
    }
}
