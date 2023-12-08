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
    public partial class FormVisitors : Form
    {
        private VisitorsController visitorsControl;
        public FormVisitors()
        {
            visitorsControl = new VisitorsController();
            InitializeComponent();
            showVisitors();
        }
        bool showVisitors()
        {
            dataGridViewVisitors.DataSource = visitorsControl.selectVisitors
                (new MySqlConnector.MySqlCommand("SELECT * FROM Visitors"));
            dataGridViewVisitors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            return true;
        }
        private void FormVisitors_Load(object sender, EventArgs e)
        {
            showVisitors();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            main.Show();
            this.Hide();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.Show();
            this.Hide();
        }
        private void btnVisitors_Click(object sender, EventArgs e)
        {
            FormVisitors vi = new FormVisitors();
            vi.Show();
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

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            FormTransaction transaction = new FormTransaction();
            transaction.Show();
            this.Hide();
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeleteId.Text = dataGridViewVisitors.CurrentRow.Cells[0].Value.ToString();
            txtDeleteName.Text = dataGridViewVisitors.CurrentRow.Cells[1].Value.ToString();
            txtDeleteGender.Text = dataGridViewVisitors.CurrentRow.Cells[2].Value.ToString();
            txtDeleteStudy.Text = dataGridViewVisitors.CurrentRow.Cells[3].Value.ToString();
            txtDeleteNeeds.Text = dataGridViewVisitors.CurrentRow.Cells[4].Value.ToString();
            txtDeleteSearch.Text = dataGridViewVisitors.CurrentRow.Cells[5].Value.ToString();
            txtDeleteDate.Text = dataGridViewVisitors.CurrentRow.Cells[6].Value.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddVisitors addVisitors = new FormAddVisitors();
            addVisitors.Show();
            this.Hide();
        }
        bool verify()
        {
            if ((txtDeleteId.Text == "") || (txtDeleteName.Text == "") || (txtDeleteGender.Text == "") || (txtDeleteStudy.Text == "") || (txtDeleteNeeds.Text == "") || (txtDeleteSearch.Text == "") || (txtDeleteDate.Text == "") || (txtDeleteTime.Text == ""))
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
            txtDeleteId.Clear();
            txtDeleteName.Clear();
            txtDeleteGender.Clear();
            txtDeleteStudy.Clear();
            txtDeleteNeeds.Clear();
            txtDeleteSearch.Clear();
            txtDeleteDate.Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                visitorsControl.deleteVisitors(txtDeleteId.Text);
                showVisitors();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateVisitors uvisitors = new FormUpdateVisitors();
            uvisitors.Show();
            this.Hide();

            uvisitors.txtId.Text = this.dataGridViewVisitors.CurrentRow.Cells[0].Value.ToString();
            uvisitors.txtNamee.Text = this.dataGridViewVisitors.CurrentRow.Cells[1].Value.ToString();
            string genderValue = (string)dataGridViewVisitors.CurrentRow.Cells[2].Value.ToString();
            if (genderValue == "M")
            {
                uvisitors.rbtGenderM.Checked = true;
            }
            else
            {
                uvisitors.rbtGenderF.Checked = true;
            }
            uvisitors.txtStudyProgram.Text = this.dataGridViewVisitors.CurrentRow.Cells[3].Value.ToString();
            uvisitors.txtNeeds.Text = this.dataGridViewVisitors.CurrentRow.Cells[4].Value.ToString();
            uvisitors.txtSearch.Text = this.dataGridViewVisitors.CurrentRow.Cells[5].Value.ToString();
            uvisitors.dateTimePickerVisitors.Value = (DateTime)this.dataGridViewVisitors.CurrentRow.Cells[6].Value;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialogVisitors.Document = printDocumentVisitors;
            printPreviewDialogVisitors.ShowDialog();
        }

        private void printDocumentVisitors_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.dataGridViewVisitors.Width, this.dataGridViewVisitors.Height);
            dataGridViewVisitors.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridViewVisitors.Width, this.dataGridViewVisitors.Height));
            e.Graphics.DrawImage(btm, 100, 170);
            e.Graphics.DrawString(lblUndip.Text, new Font("Calibri", 23, FontStyle.Bold), Brushes.Black, new Point(185, 100));
        }

        private void printPreviewDialogVisitors_Load(object sender, EventArgs e)
        {
            txtDeleteId.Text = dataGridViewVisitors.CurrentRow.Cells[0].Value.ToString();
            txtDeleteName.Text = dataGridViewVisitors.CurrentRow.Cells[1].Value.ToString();
            txtDeleteGender.Text = dataGridViewVisitors.CurrentRow.Cells[2].Value.ToString();
            txtDeleteStudy.Text = dataGridViewVisitors.CurrentRow.Cells[3].Value.ToString();
            txtDeleteNeeds.Text = dataGridViewVisitors.CurrentRow.Cells[4].Value.ToString();
            txtDeleteSearch.Text = dataGridViewVisitors.CurrentRow.Cells[5].Value.ToString();
            txtDeleteDate.Text = dataGridViewVisitors.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
