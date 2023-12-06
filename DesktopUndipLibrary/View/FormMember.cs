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
    public partial class FormMember : Form
    {
        private MemberController memberController;
        public FormMember()
        {
            memberController = new MemberController();
            InitializeComponent();
            showMember();
        }
        bool showMember()
        {
            dataGridViewMember.DataSource = memberController.selectMember
                (new MySqlConnector.MySqlCommand("SELECT * FROM Member"));
            dataGridViewMember.RowTemplate.Height = 20;
            return true;
        }
        private void FormMember_Load(object sender, EventArgs e)
        {
            showMember();
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            FormBook book = new FormBook();
            book.Show();
            this.Hide();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            FormTransaction transaction = new FormTransaction();
            transaction.Show();
            this.Hide();
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeleteMemberId.Text = dataGridViewMember.CurrentRow.Cells[0].Value.ToString();
            txtDeleteNamee.Text = dataGridViewMember.CurrentRow.Cells[1].Value.ToString();
            txtDeleteStudy.Text = dataGridViewMember.CurrentRow.Cells[2].Value.ToString();
            txtDeletePlaceofBirth.Text = dataGridViewMember.CurrentRow.Cells[3].Value.ToString();
            txtDeleteDateofBirth.Text = dataGridViewMember.CurrentRow.Cells[4].Value.ToString();
            txtDeleteTelephoneNumber.Text = dataGridViewMember.CurrentRow.Cells[5].Value.ToString();
            txtDeleteAddress.Text = dataGridViewMember.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddMember addMember = new FormAddMember();
            addMember.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateMember updateMember = new FormUpdateMember();
            updateMember.Show();
            this.Hide();

            updateMember.txtMemberId.Text = this.dataGridViewMember.CurrentRow.Cells[0].Value.ToString();
            updateMember.txtNamee.Text = this.dataGridViewMember.CurrentRow.Cells[1].Value.ToString();
            updateMember.txtStudyProgram.Text = this.dataGridViewMember.CurrentRow.Cells[2].Value.ToString();
            updateMember.txtPlaceofBirth.Text = this.dataGridViewMember.CurrentRow.Cells[3].Value.ToString();
            updateMember.dateTimePickerDateofBirth.Value = (DateTime)this.dataGridViewMember.CurrentRow.Cells[4].Value;
            updateMember.txtTelephoneNumber.Text = this.dataGridViewMember.CurrentRow.Cells[5].Value.ToString();
            updateMember.txtAddress.Text = this.dataGridViewMember.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                memberController.deleteMember(txtDeleteMemberId.Text);
                showMember();
                btnClear.PerformClick();
                MessageBox.Show("Successfully Deleted Data", "Delete Data",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDeleteMemberId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verify()
        {
            if ((txtDeleteMemberId.Text == "") || (txtDeleteNamee.Text == "") || (txtDeleteStudy.Text == "") || (txtDeletePlaceofBirth.Text == "") || (txtDeleteDateofBirth.Text == "") || (txtDeleteTelephoneNumber.Text == "") || (txtDeleteAddress.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDeleteMemberId.Clear();
            txtDeleteNamee.Clear();
            txtDeleteStudy.Clear();
            txtDeletePlaceofBirth.Clear();
            txtDeleteDateofBirth.Clear();
            txtDeleteTelephoneNumber.Clear();
            txtDeleteAddress.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Hide();
        }

        private void printDocumentMember_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.dataGridViewMember.Width, this.dataGridViewMember.Height);
            dataGridViewMember.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridViewMember.Width, this.dataGridViewMember.Height));
            e.Graphics.DrawImage(btm, 45, 170);
            e.Graphics.DrawString(lblUndip.Text, new Font("Calibri", 23, FontStyle.Bold), Brushes.Black, new Point(185, 100));
        }

        private void printPreviewDialogMember_Load(object sender, EventArgs e)
        {
            txtDeleteMemberId.Text = dataGridViewMember.CurrentRow.Cells[0].Value.ToString();
            txtDeleteNamee.Text = dataGridViewMember.CurrentRow.Cells[1].Value.ToString();
            txtDeleteStudy.Text = dataGridViewMember.CurrentRow.Cells[2].Value.ToString();
            txtDeletePlaceofBirth.Text = dataGridViewMember.CurrentRow.Cells[3].Value.ToString();
            txtDeleteDateofBirth.Text = dataGridViewMember.CurrentRow.Cells[4].Value.ToString();
            txtDeleteTelephoneNumber.Text = dataGridViewMember.CurrentRow.Cells[5].Value.ToString();
            txtDeleteAddress.Text = dataGridViewMember.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialogMember.Document = printDocumentMember;
            printPreviewDialogMember.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewMember.DataSource = memberController.searchMember(txtForSearch.Text);
            dataGridViewMember.RowTemplate.Height = 20;
        }
    }
}