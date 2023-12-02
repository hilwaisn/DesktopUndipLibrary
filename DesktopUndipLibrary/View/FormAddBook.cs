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
            if (txtTitle.Text)
            {
                try
                {
                    bookControl.addedBook(txtBookId.Text, txtTitle.Text, txtAuthor.Text, txtIssueYear.Text, txtStock.Text, txtCollectionId.Text, txtShelfId.Text);
                    MessageBox.Show("New Book Added", "Add Book",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Show();
                    txtTitle.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty field", "Add Pelatihan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormAddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
