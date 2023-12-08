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
    public partial class FormAddVisitors : Form
    {
        private VisitorsController visitorsController;
        public FormAddVisitors()
        {
            InitializeComponent();
        }
        private void FormAddVisitors_Load(object sender, EventArgs e)
        {
            txtId.MaxLength = 5;
            txtNamee.MaxLength = 50;
            txtStudyProgram.MaxLength = 45;
            txtNeeds.MaxLength = 10;
            txtSearch.MaxLength = 10;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            visitorsController = new VisitorsController();
            string gender = rbtGenderM.Checked ? "M" : "L";
            try
            {
                visitorsController.addedVisitors(txtId.Text, txtNamee.Text, gender, txtStudyProgram.Text, txtNeeds.Text, txtSearch.Text, dateTimePickerVisitors.Value);
                MessageBox.Show("New Visitors Added", "Add Visitors",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                txtNamee.Focus();
                FormVisitors visitors = new FormVisitors();
                visitors.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormVisitors visitors = new FormVisitors();
            visitors.Show();
            this.Hide();
        }
    }
}