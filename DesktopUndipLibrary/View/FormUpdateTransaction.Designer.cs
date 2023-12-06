namespace DesktopUndipLibrary.View
{
    partial class FormUpdateTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateTransaction));
            this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtNamee = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUndip = new System.Windows.Forms.Label();
            this.pictureBoxUndipLogo = new System.Windows.Forms.PictureBox();
            this.panelAddBook = new System.Windows.Forms.Panel();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.dateTimePickerLoan = new System.Windows.Forms.DateTimePicker();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblTelephoneNumber = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblNamee = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUndipLogo)).BeginInit();
            this.panelAddBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.Location = new System.Drawing.Point(429, 156);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.Size = new System.Drawing.Size(310, 26);
            this.dateTimePickerReturn.TabIndex = 15;
            // 
            // txtBookId
            // 
            this.txtBookId.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookId.Location = new System.Drawing.Point(429, 342);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(310, 42);
            this.txtBookId.TabIndex = 12;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberId.Location = new System.Drawing.Point(429, 278);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(310, 42);
            this.txtMemberId.TabIndex = 11;
            // 
            // txtNamee
            // 
            this.txtNamee.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamee.Location = new System.Drawing.Point(429, 207);
            this.txtNamee.Name = "txtNamee";
            this.txtNamee.Size = new System.Drawing.Size(310, 42);
            this.txtNamee.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(487, 629);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 49);
            this.btnSave.TabIndex = 110;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUndip
            // 
            this.lblUndip.AutoSize = true;
            this.lblUndip.BackColor = System.Drawing.Color.Transparent;
            this.lblUndip.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUndip.Location = new System.Drawing.Point(179, 17);
            this.lblUndip.Name = "lblUndip";
            this.lblUndip.Size = new System.Drawing.Size(730, 59);
            this.lblUndip.TabIndex = 109;
            this.lblUndip.Text = "DIPONEGORO UNIVERSITY LIBRARY";
            this.lblUndip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxUndipLogo
            // 
            this.pictureBoxUndipLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUndipLogo.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Logo;
            this.pictureBoxUndipLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUndipLogo.ErrorImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Logo;
            this.pictureBoxUndipLogo.InitialImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Logo;
            this.pictureBoxUndipLogo.Location = new System.Drawing.Point(913, 17);
            this.pictureBoxUndipLogo.Name = "pictureBoxUndipLogo";
            this.pictureBoxUndipLogo.Size = new System.Drawing.Size(52, 59);
            this.pictureBoxUndipLogo.TabIndex = 108;
            this.pictureBoxUndipLogo.TabStop = false;
            // 
            // panelAddBook
            // 
            this.panelAddBook.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAddBook.Controls.Add(this.txtInformation);
            this.panelAddBook.Controls.Add(this.lblInformation);
            this.panelAddBook.Controls.Add(this.dateTimePickerLoan);
            this.panelAddBook.Controls.Add(this.dateTimePickerReturn);
            this.panelAddBook.Controls.Add(this.txtBookId);
            this.panelAddBook.Controls.Add(this.txtMemberId);
            this.panelAddBook.Controls.Add(this.txtNamee);
            this.panelAddBook.Controls.Add(this.lblMemberId);
            this.panelAddBook.Controls.Add(this.lblTelephoneNumber);
            this.panelAddBook.Controls.Add(this.lblLoan);
            this.panelAddBook.Controls.Add(this.lblReturn);
            this.panelAddBook.Controls.Add(this.lblNamee);
            this.panelAddBook.Controls.Add(this.txtId);
            this.panelAddBook.Controls.Add(this.lblId);
            this.panelAddBook.Location = new System.Drawing.Point(158, 111);
            this.panelAddBook.Name = "panelAddBook";
            this.panelAddBook.Size = new System.Drawing.Size(807, 476);
            this.panelAddBook.TabIndex = 107;
            // 
            // txtInformation
            // 
            this.txtInformation.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.Location = new System.Drawing.Point(429, 411);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(310, 42);
            this.txtInformation.TabIndex = 20;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(62, 414);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(185, 35);
            this.lblInformation.TabIndex = 19;
            this.lblInformation.Text = "INFORMATION";
            // 
            // dateTimePickerLoan
            // 
            this.dateTimePickerLoan.Location = new System.Drawing.Point(429, 92);
            this.dateTimePickerLoan.Name = "dateTimePickerLoan";
            this.dateTimePickerLoan.Size = new System.Drawing.Size(310, 26);
            this.dateTimePickerLoan.TabIndex = 16;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(62, 281);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(154, 35);
            this.lblMemberId.TabIndex = 7;
            this.lblMemberId.Text = "MEMBER ID";
            // 
            // lblTelephoneNumber
            // 
            this.lblTelephoneNumber.AutoSize = true;
            this.lblTelephoneNumber.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephoneNumber.Location = new System.Drawing.Point(62, 345);
            this.lblTelephoneNumber.Name = "lblTelephoneNumber";
            this.lblTelephoneNumber.Size = new System.Drawing.Size(115, 35);
            this.lblTelephoneNumber.TabIndex = 6;
            this.lblTelephoneNumber.Text = "BOOK ID";
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoan.Location = new System.Drawing.Point(62, 86);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(147, 35);
            this.lblLoan.TabIndex = 4;
            this.lblLoan.Text = "LOAN DATE";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.Location = new System.Drawing.Point(62, 150);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(177, 35);
            this.lblReturn.TabIndex = 3;
            this.lblReturn.Text = "RETURN DATE";
            // 
            // lblNamee
            // 
            this.lblNamee.AutoSize = true;
            this.lblNamee.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamee.Location = new System.Drawing.Point(62, 214);
            this.lblNamee.Name = "lblNamee";
            this.lblNamee.Size = new System.Drawing.Size(88, 35);
            this.lblNamee.TabIndex = 2;
            this.lblNamee.Text = "NAME";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(429, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(310, 42);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(62, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 35);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(944, 629);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 46);
            this.btnCancel.TabIndex = 111;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormUpdateTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Front_Undip_Building;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 694);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblUndip);
            this.Controls.Add(this.pictureBoxUndipLogo);
            this.Controls.Add(this.panelAddBook);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUpdateTransaction";
            this.Text = "Update Transaction Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUndipLogo)).EndInit();
            this.panelAddBook.ResumeLayout(false);
            this.panelAddBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUndip;
        private System.Windows.Forms.PictureBox pictureBoxUndipLogo;
        private System.Windows.Forms.Panel panelAddBook;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblTelephoneNumber;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblNamee;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.DateTimePicker dateTimePickerReturn;
        public System.Windows.Forms.TextBox txtBookId;
        public System.Windows.Forms.TextBox txtMemberId;
        public System.Windows.Forms.TextBox txtNamee;
        public System.Windows.Forms.DateTimePicker dateTimePickerLoan;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Label lblInformation;
    }
}