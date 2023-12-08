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
        bool verify()
        {
            if ((txtId.Text == "") || (txtNamee.Text == "") || (txtStudyProgram.Text == "") || (txtNeeds.Text == "") || (txtSearch.Text == ""))
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
            visitorsController = new VisitorsController();
            ValidasiController val = new ValidasiController();
            string gender = rbtGenderM.Checked ? "M" : "F";
            if (verify())
            {
                if (val.valId(txtId.Text) && val.valName(txtNamee.Text) && val.valName(txtNamee.Text) && val.valStudy(txtStudyProgram.Text) && val.valName(txtNeeds.Text) && val.valName(txtSearch.Text))
                {
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