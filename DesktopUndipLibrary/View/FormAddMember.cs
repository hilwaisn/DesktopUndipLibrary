using DesktopUndipLibrary.Controller;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        private void FormAddMember_Load(object sender, EventArgs e)
        {
            txtMemberId.MaxLength = 12;
            txtNamee.MaxLength = 45;
            txtStudyProgram.MaxLength = 45;
            txtPlaceofBirth.MaxLength = 50;
            txtTelephoneNumber.MaxLength = 13;
            txtAddress.MaxLength = 50;
        }
        bool verify()
        {
            if ((txtMemberId.Text == "") || (txtNamee.Text == "") || (txtStudyProgram.Text == "") || (txtPlaceofBirth.Text == "") || (txtTelephoneNumber.Text == "") || (txtAddress.Text == ""))
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
            memberController = new MemberController();
            ValidasiController val = new ValidasiController();
            if (verify())
            {
                if (val.valId(txtMemberId.Text) && val.valName(txtNamee.Text) && val.valPob(txtPlaceofBirth.Text) && val.valAddress(txtAddress.Text)&&val.valStudy(txtStudyProgram.Text)&&val.valTn(txtTelephoneNumber.Text))
                {
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
            }
            else
            {
                MessageBox.Show("Empty field", "Add Member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormMember member = new FormMember();
            member.Show();
            this.Hide();
        }

        private void txtMemberId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtNamee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void dateTimePickerDateofBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dateTimePickerDateofBirth.Value > DateTime.Today)
            {
                MessageBox.Show("The date cannot be in the future", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerDateofBirth.Value = DateTime.Today;
            }
        }
    }
}