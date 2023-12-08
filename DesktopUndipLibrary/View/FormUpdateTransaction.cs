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
    public partial class FormUpdateTransaction : Form
    {
        private TransactionController transactioncontrol;
        public FormUpdateTransaction()
        {
            InitializeComponent();
        }
        private void FormUpdateTransaction_Load(object sender, EventArgs e)
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
                    transactioncontrol.updateTransaction(txtId.Text, dateTimePickerLoan.Value, dateTimePickerReturn.Value, txtNamee.Text, txtMemberId.Text, txtBookId.Text, txtInformation.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    txtNamee.Focus();
                    MessageBox.Show("Data Saved");
                    FormTransaction transaction = new FormTransaction();
                    transaction.Show();
                    this.Hide();
                }
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
