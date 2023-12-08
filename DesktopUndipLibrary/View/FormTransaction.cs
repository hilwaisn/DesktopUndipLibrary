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
    public partial class FormTransaction : Form
    {
        private TransactionController transactionControl;
        public FormTransaction()
        {
            transactionControl = new TransactionController();
            InitializeComponent();
            showTransaction();
        }
        bool showTransaction()
        {
            dataGridViewTransaction.DataSource = transactionControl.selectTransaction
                (new MySqlConnector.MySqlCommand("SELECT * FROM Transaction"));
            dataGridViewTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            return true;
        }
        private void FormTransaction_Load(object sender, EventArgs e)
        {
            txtForSearch.MaxLength = 10;
            showTransaction();
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            FormBook book = new FormBook();
            book.Show(); 
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddTransaction atransaction = new FormAddTransaction();
            atransaction.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateTransaction utransaction = new FormUpdateTransaction();
            utransaction.Show();
            this.Hide();

            utransaction.txtId.Text = this.dataGridViewTransaction.CurrentRow.Cells[0].Value.ToString();
            utransaction.dateTimePickerLoan.Value = (DateTime)this.dataGridViewTransaction.CurrentRow.Cells[1].Value;
            utransaction.dateTimePickerReturn.Value = (DateTime)this.dataGridViewTransaction.CurrentRow.Cells[2].Value;
            utransaction.txtNamee.Text = this.dataGridViewTransaction.CurrentRow.Cells[3].Value.ToString();
            utransaction.txtMemberId.Text = this.dataGridViewTransaction.CurrentRow.Cells[4].Value.ToString();
            utransaction.txtBookId.Text = this.dataGridViewTransaction.CurrentRow.Cells[5].Value.ToString();
            utransaction.txtInformation.Text = this.dataGridViewTransaction.CurrentRow.Cells[6].Value.ToString();
        }

        bool verify()
        {
            if ((txtDeleteId.Text == "") || (txtDeleteLoan.Text == "") || (txtDeleteReturn.Text == "") || (txtDeleteName.Text == "") || (txtDeleteMemberId.Text == "") || (txtDeleteBookId.Text == ""))
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
            try
            {
                transactionControl.deleteTransaction(txtDeleteId.Text);
                showTransaction();
                btnClear.PerformClick();
                MessageBox.Show("Successfully Deleted Data", "Delete Data",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDeleteId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDeleteId.Clear();
            txtDeleteLoan.Clear();
            txtDeleteReturn.Clear();
            txtDeleteName.Clear();
            txtDeleteMemberId.Clear();
            txtDeleteBookId.Clear();
            txtDeleteInformation.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialogTransaction.Document = printDocumentTransaction;
            printPreviewDialogTransaction.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Hide();
        }

        private void printDocumentTransaction_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.dataGridViewTransaction.Width, this.dataGridViewTransaction.Height);
            dataGridViewTransaction.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridViewTransaction.Width, this.dataGridViewTransaction.Height));
            e.Graphics.DrawImage(btm, 45, 170);
            e.Graphics.DrawString(lblUndip.Text, new Font("Calibri", 23, FontStyle.Bold), Brushes.Black, new Point(185, 100));
        }

        private void printPreviewDialogTransaction_Load(object sender, EventArgs e)
        {
            txtDeleteId.Text = dataGridViewTransaction.CurrentRow.Cells[0].Value.ToString();
            txtDeleteLoan.Text = dataGridViewTransaction.CurrentRow.Cells[1].Value.ToString();
            txtDeleteReturn.Text = dataGridViewTransaction.CurrentRow.Cells[2].Value.ToString();
            txtDeleteName.Text = dataGridViewTransaction.CurrentRow.Cells[3].Value.ToString();
            txtDeleteMemberId.Text = dataGridViewTransaction.CurrentRow.Cells[4].Value.ToString();
            txtDeleteBookId.Text = dataGridViewTransaction.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewTransaction.DataSource = transactionControl.searchTransaction(txtForSearch.Text);
            dataGridViewTransaction.RowTemplate.Height = 20;
        }
    }
}