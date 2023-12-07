namespace DesktopUndipLibrary.View
{
    partial class FormTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaction));
            this.pictureBoxBook = new System.Windows.Forms.PictureBox();
            this.pictureBoxMember = new System.Windows.Forms.PictureBox();
            this.pictureBoxVisitors = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.pictureBoxAccount = new System.Windows.Forms.PictureBox();
            this.lblUndip = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnVisitors = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.pictureBoxUndipLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewTransaction = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.txtDeleteName = new System.Windows.Forms.TextBox();
            this.txtDeleteMemberId = new System.Windows.Forms.TextBox();
            this.txtDeleteBookId = new System.Windows.Forms.TextBox();
            this.txtDeleteLoan = new System.Windows.Forms.TextBox();
            this.txtDeleteReturn = new System.Windows.Forms.TextBox();
            this.printDocumentTransaction = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogTransaction = new System.Windows.Forms.PrintPreviewDialog();
            this.txtDeleteInformation = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtForSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUndipLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBook
            // 
            this.pictureBoxBook.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxBook.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Book;
            this.pictureBoxBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBook.Location = new System.Drawing.Point(15, 523);
            this.pictureBoxBook.Name = "pictureBoxBook";
            this.pictureBoxBook.Size = new System.Drawing.Size(63, 56);
            this.pictureBoxBook.TabIndex = 81;
            this.pictureBoxBook.TabStop = false;
            // 
            // pictureBoxMember
            // 
            this.pictureBoxMember.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxMember.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Member;
            this.pictureBoxMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMember.Location = new System.Drawing.Point(12, 442);
            this.pictureBoxMember.Name = "pictureBoxMember";
            this.pictureBoxMember.Size = new System.Drawing.Size(78, 50);
            this.pictureBoxMember.TabIndex = 80;
            this.pictureBoxMember.TabStop = false;
            // 
            // pictureBoxVisitors
            // 
            this.pictureBoxVisitors.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxVisitors.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Visitors;
            this.pictureBoxVisitors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxVisitors.Location = new System.Drawing.Point(12, 354);
            this.pictureBoxVisitors.Name = "pictureBoxVisitors";
            this.pictureBoxVisitors.Size = new System.Drawing.Size(75, 56);
            this.pictureBoxVisitors.TabIndex = 79;
            this.pictureBoxVisitors.TabStop = false;
            // 
            // pictureBoxAdmin
            // 
            this.pictureBoxAdmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxAdmin.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Account1;
            this.pictureBoxAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAdmin.Location = new System.Drawing.Point(12, 267);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(63, 61);
            this.pictureBoxAdmin.TabIndex = 78;
            this.pictureBoxAdmin.TabStop = false;
            // 
            // pictureBoxAccount
            // 
            this.pictureBoxAccount.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAccount.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Account1;
            this.pictureBoxAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAccount.Location = new System.Drawing.Point(35, 78);
            this.pictureBoxAccount.Name = "pictureBoxAccount";
            this.pictureBoxAccount.Size = new System.Drawing.Size(149, 156);
            this.pictureBoxAccount.TabIndex = 77;
            this.pictureBoxAccount.TabStop = false;
            // 
            // lblUndip
            // 
            this.lblUndip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUndip.AutoSize = true;
            this.lblUndip.BackColor = System.Drawing.Color.Transparent;
            this.lblUndip.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUndip.Location = new System.Drawing.Point(271, 17);
            this.lblUndip.Name = "lblUndip";
            this.lblUndip.Size = new System.Drawing.Size(730, 59);
            this.lblUndip.TabIndex = 76;
            this.lblUndip.Text = "DIPONEGORO UNIVERSITY LIBRARY";
            this.lblUndip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTransaction.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.Location = new System.Drawing.Point(1, 591);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(230, 90);
            this.btnTransaction.TabIndex = 75;
            this.btnTransaction.Text = "TRANSACTION";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.UseVisualStyleBackColor = false;
            // 
            // btnVisitors
            // 
            this.btnVisitors.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVisitors.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitors.Location = new System.Drawing.Point(1, 336);
            this.btnVisitors.Name = "btnVisitors";
            this.btnVisitors.Size = new System.Drawing.Size(230, 90);
            this.btnVisitors.TabIndex = 74;
            this.btnVisitors.Text = "VISITORS";
            this.btnVisitors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisitors.UseVisualStyleBackColor = false;
            this.btnVisitors.Click += new System.EventHandler(this.btnVisitors_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdmin.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(1, 252);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(230, 90);
            this.btnAdmin.TabIndex = 73;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMember.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.Location = new System.Drawing.Point(1, 422);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(230, 90);
            this.btnMember.TabIndex = 72;
            this.btnMember.Text = "MEMBER";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBook.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(1, 507);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(230, 90);
            this.btnBook.TabIndex = 71;
            this.btnBook.Text = "BOOK";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // pictureBoxUndipLogo
            // 
            this.pictureBoxUndipLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxUndipLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUndipLogo.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Logo;
            this.pictureBoxUndipLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUndipLogo.ErrorImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Logo;
            this.pictureBoxUndipLogo.InitialImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Logo;
            this.pictureBoxUndipLogo.Location = new System.Drawing.Point(1005, 17);
            this.pictureBoxUndipLogo.Name = "pictureBoxUndipLogo";
            this.pictureBoxUndipLogo.Size = new System.Drawing.Size(52, 59);
            this.pictureBoxUndipLogo.TabIndex = 70;
            this.pictureBoxUndipLogo.TabStop = false;
            // 
            // dataGridViewTransaction
            // 
            this.dataGridViewTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTransaction.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaction.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTransaction.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataGridViewTransaction.Location = new System.Drawing.Point(233, 108);
            this.dataGridViewTransaction.Name = "dataGridViewTransaction";
            this.dataGridViewTransaction.RowHeadersWidth = 62;
            this.dataGridViewTransaction.RowTemplate.Height = 28;
            this.dataGridViewTransaction.Size = new System.Drawing.Size(1095, 503);
            this.dataGridViewTransaction.TabIndex = 66;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(244, 631);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.TabIndex = 88;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(344, 631);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 40);
            this.btnUpdate.TabIndex = 87;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrint.Location = new System.Drawing.Point(711, 631);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 40);
            this.btnPrint.TabIndex = 86;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(944, 631);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 40);
            this.btnCancel.TabIndex = 85;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(600, 631);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 40);
            this.btnClear.TabIndex = 84;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(472, 631);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 40);
            this.btnDelete.TabIndex = 83;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDeleteId.Location = new System.Drawing.Point(12, 518);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(1, 26);
            this.txtDeleteId.TabIndex = 89;
            // 
            // txtDeleteName
            // 
            this.txtDeleteName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDeleteName.Location = new System.Drawing.Point(10, 559);
            this.txtDeleteName.Name = "txtDeleteName";
            this.txtDeleteName.Size = new System.Drawing.Size(1, 26);
            this.txtDeleteName.TabIndex = 90;
            // 
            // txtDeleteMemberId
            // 
            this.txtDeleteMemberId.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDeleteMemberId.Location = new System.Drawing.Point(8, 432);
            this.txtDeleteMemberId.Name = "txtDeleteMemberId";
            this.txtDeleteMemberId.Size = new System.Drawing.Size(1, 26);
            this.txtDeleteMemberId.TabIndex = 91;
            // 
            // txtDeleteBookId
            // 
            this.txtDeleteBookId.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDeleteBookId.Location = new System.Drawing.Point(12, 559);
            this.txtDeleteBookId.Name = "txtDeleteBookId";
            this.txtDeleteBookId.Size = new System.Drawing.Size(1, 26);
            this.txtDeleteBookId.TabIndex = 92;
            // 
            // txtDeleteLoan
            // 
            this.txtDeleteLoan.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDeleteLoan.Location = new System.Drawing.Point(18, 599);
            this.txtDeleteLoan.Name = "txtDeleteLoan";
            this.txtDeleteLoan.Size = new System.Drawing.Size(1, 26);
            this.txtDeleteLoan.TabIndex = 93;
            // 
            // txtDeleteReturn
            // 
            this.txtDeleteReturn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDeleteReturn.Location = new System.Drawing.Point(84, 544);
            this.txtDeleteReturn.Name = "txtDeleteReturn";
            this.txtDeleteReturn.Size = new System.Drawing.Size(1, 26);
            this.txtDeleteReturn.TabIndex = 94;
            // 
            // printDocumentTransaction
            // 
            this.printDocumentTransaction.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentTransaction_PrintPage);
            // 
            // printPreviewDialogTransaction
            // 
            this.printPreviewDialogTransaction.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogTransaction.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogTransaction.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogTransaction.Enabled = true;
            this.printPreviewDialogTransaction.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogTransaction.Icon")));
            this.printPreviewDialogTransaction.Name = "printPreviewDialogTransaction";
            this.printPreviewDialogTransaction.Visible = false;
            this.printPreviewDialogTransaction.Load += new System.EventHandler(this.printPreviewDialogTransaction_Load);
            // 
            // txtDeleteInformation
            // 
            this.txtDeleteInformation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDeleteInformation.Location = new System.Drawing.Point(96, 479);
            this.txtDeleteInformation.Name = "txtDeleteInformation";
            this.txtDeleteInformation.Size = new System.Drawing.Size(1, 26);
            this.txtDeleteInformation.TabIndex = 95;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1163, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 113;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtForSearch
            // 
            this.txtForSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForSearch.Location = new System.Drawing.Point(927, 77);
            this.txtForSearch.Name = "txtForSearch";
            this.txtForSearch.Size = new System.Drawing.Size(224, 26);
            this.txtForSearch.TabIndex = 112;
            // 
            // FormTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Horse_Statue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1328, 694);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtForSearch);
            this.Controls.Add(this.txtDeleteInformation);
            this.Controls.Add(this.txtDeleteReturn);
            this.Controls.Add(this.txtDeleteLoan);
            this.Controls.Add(this.txtDeleteBookId);
            this.Controls.Add(this.txtDeleteMemberId);
            this.Controls.Add(this.txtDeleteName);
            this.Controls.Add(this.txtDeleteId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pictureBoxBook);
            this.Controls.Add(this.pictureBoxMember);
            this.Controls.Add(this.pictureBoxVisitors);
            this.Controls.Add(this.pictureBoxAdmin);
            this.Controls.Add(this.pictureBoxAccount);
            this.Controls.Add(this.lblUndip);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnVisitors);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.pictureBoxUndipLogo);
            this.Controls.Add(this.dataGridViewTransaction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTransaction";
            this.Text = "Transaction Page";
            this.Load += new System.EventHandler(this.FormTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUndipLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxBook;
        private System.Windows.Forms.PictureBox pictureBoxMember;
        private System.Windows.Forms.PictureBox pictureBoxVisitors;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private System.Windows.Forms.PictureBox pictureBoxAccount;
        private System.Windows.Forms.Label lblUndip;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnVisitors;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.PictureBox pictureBoxUndipLogo;
        private System.Windows.Forms.DataGridView dataGridViewTransaction;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.TextBox txtDeleteName;
        private System.Windows.Forms.TextBox txtDeleteMemberId;
        private System.Windows.Forms.TextBox txtDeleteBookId;
        private System.Windows.Forms.TextBox txtDeleteLoan;
        private System.Windows.Forms.TextBox txtDeleteReturn;
        private System.Drawing.Printing.PrintDocument printDocumentTransaction;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogTransaction;
        private System.Windows.Forms.TextBox txtDeleteInformation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtForSearch;
    }
}