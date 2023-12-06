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
    public partial class FormUpdateVisitors : Form
    {
        private VisitorsController visitorsController;
        public FormUpdateVisitors()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            visitorsController = new VisitorsController();
            string gender = rbtGenderM.Checked ? "M" : "L";
            visitorsController.updateVisitors(txtId.Text, txtNamee.Text, gender, txtStudyProgram.Text, txtNeeds.Text, txtSearch.Text, dateTimePickerVisitors.Value);
            this.Controls.Clear();
            this.InitializeComponent();
            txtNamee.Focus();
            MessageBox.Show("Data Saved");
            FormVisitors visitors = new FormVisitors();
            visitors.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormVisitors visitors = new FormVisitors();
            visitors.Show();
            this.Close();
        }
    }
}
