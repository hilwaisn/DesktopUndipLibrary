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

        private void FormAddBook_Load(object sender, EventArgs e)
        {
            txtBookId.MaxLength = 5;
            txtTitle.MaxLength = 100;
            txtAuthor.MaxLength = 50;
            txtIssueYear.MaxLength = 4;
            txtStock.MaxLength = 3;
            txtCollectionId.MaxLength = 5;
            txtShelfId.MaxLength = 2;
        }
        bool verify()
        {
            if ((txtBookId.Text == "") || (txtTitle.Text == "") || (txtAuthor.Text == "") || (txtIssueYear.Text == "") || (txtStock.Text == "")||(txtCollectionId.Text == "")|| (txtShelfId.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bookControl = new BookController();
            ValidasiController val = new ValidasiController();
            int Stock = Convert.ToInt32(txtStock.Text);
            if (verify())
            {
                if (val.valId(txtBookId.Text) && val.valTitle(txtTitle.Text) || val.valName(txtAuthor.Text) || val.valTn(txtIssueYear.Text) || val.valTn(txtStock.Text) || val.valId(txtCollectionId.Text) || val.valId(txtShelfId.Text))
                {
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