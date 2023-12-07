using DesktopUndipLibrary.Controller;
using RestSharp;
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
    public partial class FormAddMember : Form
    {
        private MemberController memberController;
        public FormAddMember()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            memberController = new MemberController();
            try
            {
                memberController.addedMember(txtMemberId.Text, txtNamee.Text, txtStudyProgram.Text, txtPlaceofBirth.Text, dateTimePickerDateofBirth.Value, txtTelephoneNumber.Text, txtAddress.Text);
                MessageBox.Show("New Member Added", "Add Member",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                txtNamee.Focus();
                FormMember member = new FormMember();
                member.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMember member = new FormMember();
            member.Show();
            this.Hide();
        }
    }
}