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
    public partial class FormUpdateBook : Form
    {
        private BookController bookControl;
        public FormUpdateBook()
        {
            InitializeComponent();
        }
        private void FormUpdateBook_Load(object sender, EventArgs e)
        {
            txtBookId.MaxLength = 5;
            txtTitle.MaxLength = 100;
            txtAuthor.MaxLength = 50;
            txtIssueYear.MaxLength = 4;
            txtStock.MaxLength = 3;
            txtCollectionId.MaxLength = 5;
            txtShelfId.MaxLength = 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bookControl = new BookController();
            int Stock = Convert.ToInt32(txtStock.Text);
            int Year = Convert.ToInt32(txtIssueYear.Text);
            bookControl.updateBook(txtBookId.Text, txtTitle.Text, txtAuthor.Text, Year, Stock, txtCollectionId.Text, txtShelfId.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtTitle.Focus();
            MessageBox.Show("Data Saved");
            FormBook book = new FormBook();
            book.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormBook book = new FormBook();
            book.Show();
            this.Hide();
        }
    }
}
