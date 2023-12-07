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
    public partial class FormAddBook : Form
    {
        private BookController bookControl;
        public FormAddBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bookControl = new BookController();
            int Stock = Convert.ToInt32(txtStock.Text);
            try
            {
                bookControl.addedBook(txtBookId.Text, txtTitle.Text, txtAuthor.Text, txtIssueYear.Text, Stock, txtCollectionId.Text, txtShelfId.Text);
                MessageBox.Show("New Book Added", "Add Book",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                txtTitle.Focus();
                FormBook book = new FormBook();
                book.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormBook book = new FormBook();
            book.Show();
            this.Hide();
        }
    }
}