using MySqlConnector;
using DesktopUndipLibrary.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            dataGridViewBook.DataSource = bookControl.selectBook
                (new MySqlConnector.MySqlCommand("SELECT * FROM Book"));
            dataGridViewBook.RowTemplate.Height = 30;
            return true;
        }
        private void FormBook_Load(object sender, EventArgs e)
        {
            showBook();
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
            FormMember member = new FormMember();
            member.Show();
            this.Hide();
        }
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            FormTransaction transaction = new FormTransaction();
            transaction.Show();
            this.Hide();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddBook addBook = new FormAddBook();
            addBook.Show();
            this.Hide();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Hide();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateBook ubook = new FormUpdateBook();
            ubook.Show();
            this.Hide();

            ubook.txtBookId.Text = this.dataGridViewBook.CurrentRow.Cells[0].Value.ToString();
            ubook.txtTitle.Text = this.dataGridViewBook.CurrentRow.Cells[1].Value.ToString();
            ubook.txtAuthor.Text = this.dataGridViewBook.CurrentRow.Cells[2].Value.ToString();
            ubook.txtIssueYear.Text = this.dataGridViewBook.CurrentRow.Cells[3].Value.ToString();
            ubook.txtStock.Text = this.dataGridViewBook.CurrentRow.Cells[4].Value.ToString();
            ubook.txtCollectionId.Text = this.dataGridViewBook.CurrentRow.Cells[5].Value.ToString();
            ubook.txtShelfId.Text = this.dataGridViewBook.CurrentRow.Cells[6].Value.ToString();
        }
        bool verify()
        {
            if ((txtDeleteBookId.Text == "") || (txtDeleteTitle.Text == "") || (txtDeleteAuthor.Text == "") || (txtDeleteIssueYear.Text == "") || (txtDeleteStock.Text == "") || (txtCollectionId.Text == "") || (txtDeleteShelfId.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    bookControl.deleteBook(txtDeleteBookId.Text);
                    showBook();
                    btnClear.PerformClick();
                    MessageBox.Show("Book Deleted succesfully", "Delete Book",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDeleteBookId.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Book not delete", "Delete Book",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDeleteBookId.Clear();
            txtDeleteTitle.Clear();
            txtDeleteAuthor.Clear();
            txtDeleteIssueYear.Clear();
            txtDeleteStock.Clear();
            txtCollectionId.Clear();
            txtDeleteShelfId.Clear();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialogBook.Document = printDocumentBook;
            printPreviewDialogBook.ShowDialog();
        }
        private void btnRack_Click(object sender, EventArgs e)
        {
            FormRack rack = new FormRack();
            rack.Show();
            this.Hide();
        }
        private void btnBookCollection_Click(object sender, EventArgs e)
        {
            FormBookCollection bookCollection = new FormBookCollection();
            bookCollection.Show();
            this.Hide();
        }
        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeleteBookId.Text = dataGridViewBook.CurrentRow.Cells[0].Value.ToString();
            txtDeleteTitle.Text = dataGridViewBook.CurrentRow.Cells[1].Value.ToString();
            txtDeleteAuthor.Text = dataGridViewBook.CurrentRow.Cells[2].Value.ToString();
            txtDeleteIssueYear.Text = dataGridViewBook.CurrentRow.Cells[3].Value.ToString();
            txtDeleteStock.Text = Convert.ToInt32(dataGridViewBook.CurrentRow.Cells[4].Value).ToString();
            txtCollectionId.Text = dataGridViewBook.CurrentRow.Cells[5].Value.ToString();
            txtDeleteShelfId.Text = dataGridViewBook.CurrentRow.Cells[6].Value.ToString();
        }
        private void printDocumentBook_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.dataGridViewBook.Width, this.dataGridViewBook.Height);
            dataGridViewBook.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridViewBook.Width, this.dataGridViewBook.Height));
            e.Graphics.DrawImage(btm, 45, 170);
            e.Graphics.DrawString(lblUndip.Text, new Font("Calibri", 23, FontStyle.Bold), Brushes.Black, new Point(185, 100));
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewBook.DataSource = bookControl.searchBook(txtForSearch.Text);
            dataGridViewBook.RowTemplate.Height = 30;
        }
    }
}
