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
    public partial class FormAddTransaction : Form
    {
        private TransactionController transactioncontrol;
        public FormAddTransaction()
        {
            InitializeComponent();
        }

        private void FormAddTransaction_Load(object sender, EventArgs e)
        {
            txtId.MaxLength = 5;
            txtNamee.MaxLength = 45;
            txtMemberId.MaxLength = 12;
            txtBookId.MaxLength = 5;
            txtInformation.MaxLength = 13;
        }
        bool verify()
        {
            if ((txtId.Text == "") || (txtNamee.Text == "") || (txtMemberId.Text == "") || (txtBookId.Text == "") || (txtInformation.Text == ""))
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
            transactioncontrol = new TransactionController();
            ValidasiController val = new ValidasiController();
            if (verify())
            {
                if (val.valId(txtId.Text) && val.valId(txtMemberId.Text) && val.valName(txtNamee.Text) && val.valId(txtBookId.Text) && val.valName(txtInformation.Text))
                {
                    try
                    {
                        transactioncontrol.addedTransaction(txtId.Text, dateTimePickerLoan.Value, dateTimePickerReturn.Value, txtNamee.Text, txtMemberId.Text, txtBookId.Text, txtInformation.Text);
                        MessageBox.Show("New Transaction Added", "Add Transaction",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Show();
                        txtNamee.Focus();
                        FormTransaction transaction = new FormTransaction();
                        transaction.Show();
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
            FormTransaction transaction = new FormTransaction();
            transaction.Show();
            this.Hide();
        }

        private void dateTimePickerReturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dateTimePickerReturn.Value < dateTimePickerLoan.Value)
            {
                MessageBox.Show("The date cannot be in the past", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerReturn.Value = DateTime.Today; 
            }
        }

        private void dateTimePickerLoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dateTimePickerLoan.Value > DateTime.Now)
            {
                MessageBox.Show("The date cannot be in the future", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerReturn.Value = DateTime.Today;
            }

        }
    }
}