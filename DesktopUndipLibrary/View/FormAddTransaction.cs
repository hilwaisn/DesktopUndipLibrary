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

        private void btnSave_Click(object sender, EventArgs e)
        {
            transactioncontrol = new TransactionController();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormTransaction transaction = new FormTransaction();
            transaction.Show();
            this.Hide();
        }
    }
}