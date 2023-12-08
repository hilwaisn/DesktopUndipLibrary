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
    public partial class FormUpdateMember : Form
    {
        private MemberController memberController;
        public FormUpdateMember()
        {
            InitializeComponent();
        }
        private void FormUpdateMember_Load(object sender, EventArgs e)
        {
            txtMemberId.MaxLength = 12;
            txtNamee.MaxLength = 45;
            txtStudyProgram.MaxLength = 45;
            txtPlaceofBirth.MaxLength = 50;
            txtTelephoneNumber.MaxLength = 13;
            txtAddress.MaxLength = 50;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            memberController = new MemberController();
            memberController.updateMember(txtMemberId.Text, txtNamee.Text, txtStudyProgram.Text, txtPlaceofBirth.Text, dateTimePickerDateofBirth.Value, txtTelephoneNumber.Text, txtAddress.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtNamee.Focus();
            MessageBox.Show("Data Saved");
            FormMember member = new FormMember();
            member.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMember member = new FormMember();
            member.Show();
            this.Hide();
        }
    }
}
