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
    public partial class FormBookCollection : Form
    {
        private BookCollectionController bookcollectionControl;
        public FormBookCollection()
        {
            bookcollectionControl = new BookCollectionController();
            InitializeComponent();
            showBookCollection();
        }

        bool showBookCollection()
        {
            dataGridViewBookCollection.DataSource = bookcollectionControl.selectBookCollection
                (new MySqlConnector.MySqlCommand("SELECT * FROM BookCollection"));
            dataGridViewBookCollection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            return true;
        }

        private void FormBookCollection_Load(object sender, EventArgs e)
        {
            showBookCollection();
        }

        bool verify()
        {
            if ((txtId.Text == "") || (txtName.Text == ""))
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
                bookcollectionControl.deleteBookCollection(txtId.Text);
                showBookCollection();
                btnClear.PerformClick();
                MessageBox.Show("Book Collection Deleted succesfully", "Delete Book Collection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormBook book = new FormBook();
            book.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bookcollectionControl = new BookCollectionController();
            try
            {
                bookcollectionControl.addedBookCollection(txtId.Text, txtName.Text);
                MessageBox.Show("New Book Collection Added", "Add Book Collection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                txtId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            showBookCollection();
        }

        private void dataGridViewBookCollection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridViewBookCollection.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridViewBookCollection.CurrentRow.Cells[1].Value.ToString();
        }
    }
}