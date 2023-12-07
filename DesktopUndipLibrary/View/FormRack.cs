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
    public partial class FormRack : Form
    {
        private RackController rackControl;
        public FormRack()
        {
            rackControl = new RackController();
            InitializeComponent();
            showRack();
        }

        bool showRack()
        {
            dataGridViewRack.DataSource = rackControl.selectRack
                (new MySqlConnector.MySqlCommand("SELECT * FROM Rack"));
            dataGridViewRack.RowTemplate.Height = 20;
            return true;
        }

        private void FormRack_Load(object sender, EventArgs e)
        {
            showRack();
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
                rackControl.deleteRack(txtId.Text);
                showRack();
                btnClear.PerformClick();
                MessageBox.Show("Rack Deleted succesfully", "Delete Rack",
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
            rackControl = new RackController();
            try
            {
                rackControl.addedRack(txtId.Text, txtName.Text);
                MessageBox.Show("New Rack Added", "Add Rack",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                txtId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            showRack();
        }

        private void dataGridViewRack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridViewRack.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridViewRack.CurrentRow.Cells[1].Value.ToString();
        }
    }
}