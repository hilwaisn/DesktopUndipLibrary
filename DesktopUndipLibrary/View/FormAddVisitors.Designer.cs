namespace DesktopUndipLibrary.View
{
    partial class FormAddVisitors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddVisitors));
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblDatee = new System.Windows.Forms.Label();
            this.lblNamee = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblStudyProgram = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblUndip = new System.Windows.Forms.Label();
            this.panelAddBook = new System.Windows.Forms.Panel();
            this.dateTimePickerVisitors = new System.Windows.Forms.DateTimePicker();
            this.rbtGenderM = new System.Windows.Forms.RadioButton();
            this.rbtGenderF = new System.Windows.Forms.RadioButton();
            this.txtNamee = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtNeeds = new System.Windows.Forms.TextBox();
            this.txtStudyProgram = new System.Windows.Forms.TextBox();
            this.lblNeeds = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBoxUndipLogo = new System.Windows.Forms.PictureBox();
            this.panelAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUndipLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(945, 632);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 46);
            this.btnCancel.TabIndex = 106;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(65, 362);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(108, 35);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "SEARCH";
            // 
            // lblDatee
            // 
            this.lblDatee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatee.AutoSize = true;
            this.lblDatee.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatee.Location = new System.Drawing.Point(66, 425);
            this.lblDatee.Name = "lblDatee";
            this.lblDatee.Size = new System.Drawing.Size(75, 35);
            this.lblDatee.TabIndex = 5;
            this.lblDatee.Text = "DATE";
            // 
            // lblNamee
            // 
            this.lblNamee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNamee.AutoSize = true;
            this.lblNamee.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamee.Location = new System.Drawing.Point(65, 91);
            this.lblNamee.Name = "lblNamee";
            this.lblNamee.Size = new System.Drawing.Size(88, 35);
            this.lblNamee.TabIndex = 4;
            this.lblNamee.Text = "NAME";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(65, 161);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(113, 35);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "GENDER";
            // 
            // lblStudyProgram
            // 
            this.lblStudyProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudyProgram.AutoSize = true;
            this.lblStudyProgram.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudyProgram.Location = new System.Drawing.Point(65, 230);
            this.lblStudyProgram.Name = "lblStudyProgram";
            this.lblStudyProgram.Size = new System.Drawing.Size(223, 35);
            this.lblStudyProgram.TabIndex = 2;
            this.lblStudyProgram.Text = "STUDY PROGRAM";
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(432, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(310, 42);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(65, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 35);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblUndip
            // 
            this.lblUndip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUndip.AutoSize = true;
            this.lblUndip.BackColor = System.Drawing.Color.Transparent;
            this.lblUndip.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUndip.Location = new System.Drawing.Point(180, 15);
            this.lblUndip.Name = "lblUndip";
            this.lblUndip.Size = new System.Drawing.Size(730, 59);
            this.lblUndip.TabIndex = 104;
            this.lblUndip.Text = "DIPONEGORO UNIVERSITY LIBRARY";
            this.lblUndip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelAddBook
            // 
            this.panelAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddBook.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAddBook.Controls.Add(this.dateTimePickerVisitors);
            this.panelAddBook.Controls.Add(this.rbtGenderM);
            this.panelAddBook.Controls.Add(this.rbtGenderF);
            this.panelAddBook.Controls.Add(this.txtNamee);
            this.panelAddBook.Controls.Add(this.txtSearch);
            this.panelAddBook.Controls.Add(this.txtNeeds);
            this.panelAddBook.Controls.Add(this.txtStudyProgram);
            this.panelAddBook.Controls.Add(this.lblNeeds);
            this.panelAddBook.Controls.Add(this.lblSearch);
            this.panelAddBook.Controls.Add(this.lblDatee);
            this.panelAddBook.Controls.Add(this.lblNamee);
            this.panelAddBook.Controls.Add(this.lblGender);
            this.panelAddBook.Controls.Add(this.lblStudyProgram);
            this.panelAddBook.Controls.Add(this.txtId);
            this.panelAddBook.Controls.Add(this.lblId);
            this.panelAddBook.Location = new System.Drawing.Point(163, 91);
            this.panelAddBook.Name = "panelAddBook";
            this.panelAddBook.Size = new System.Drawing.Size(807, 510);
            this.panelAddBook.TabIndex = 102;
            // 
            // dateTimePickerVisitors
            // 
            this.dateTimePickerVisitors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerVisitors.Location = new System.Drawing.Point(432, 431);
            this.dateTimePickerVisitors.Name = "dateTimePickerVisitors";
            this.dateTimePickerVisitors.Size = new System.Drawing.Size(310, 26);
            this.dateTimePickerVisitors.TabIndex = 109;
            // 
            // rbtGenderM
            // 
            this.rbtGenderM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtGenderM.AutoSize = true;
            this.rbtGenderM.BackColor = System.Drawing.SystemColors.Control;
            this.rbtGenderM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGenderM.Location = new System.Drawing.Point(432, 159);
            this.rbtGenderM.Name = "rbtGenderM";
            this.rbtGenderM.Padding = new System.Windows.Forms.Padding(5);
            this.rbtGenderM.Size = new System.Drawing.Size(69, 43);
            this.rbtGenderM.TabIndex = 108;
            this.rbtGenderM.TabStop = true;
            this.rbtGenderM.Text = "M";
            this.rbtGenderM.UseVisualStyleBackColor = false;
            // 
            // rbtGenderF
            // 
            this.rbtGenderF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtGenderF.AutoSize = true;
            this.rbtGenderF.BackColor = System.Drawing.SystemColors.Control;
            this.rbtGenderF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGenderF.Location = new System.Drawing.Point(541, 159);
            this.rbtGenderF.Name = "rbtGenderF";
            this.rbtGenderF.Padding = new System.Windows.Forms.Padding(5);
            this.rbtGenderF.Size = new System.Drawing.Size(59, 43);
            this.rbtGenderF.TabIndex = 107;
            this.rbtGenderF.TabStop = true;
            this.rbtGenderF.Text = "F";
            this.rbtGenderF.UseVisualStyleBackColor = false;
            // 
            // txtNamee
            // 
            this.txtNamee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNamee.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamee.Location = new System.Drawing.Point(432, 91);
            this.txtNamee.Name = "txtNamee";
            this.txtNamee.Size = new System.Drawing.Size(310, 42);
            this.txtNamee.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(432, 359);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(310, 42);
            this.txtSearch.TabIndex = 11;
            // 
            // txtNeeds
            // 
            this.txtNeeds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNeeds.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeeds.Location = new System.Drawing.Point(432, 291);
            this.txtNeeds.Name = "txtNeeds";
            this.txtNeeds.Size = new System.Drawing.Size(310, 42);
            this.txtNeeds.TabIndex = 9;
            // 
            // txtStudyProgram
            // 
            this.txtStudyProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudyProgram.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudyProgram.Location = new System.Drawing.Point(432, 223);
            this.txtStudyProgram.Name = "txtStudyProgram";
            this.txtStudyProgram.Size = new System.Drawing.Size(310, 42);
            this.txtStudyProgram.TabIndex = 8;
            // 
            // lblNeeds
            // 
            this.lblNeeds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNeeds.AutoSize = true;
            this.lblNeeds.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeeds.Location = new System.Drawing.Point(65, 298);
            this.lblNeeds.Name = "lblNeeds";
            this.lblNeeds.Size = new System.Drawing.Size(92, 35);
            this.lblNeeds.TabIndex = 7;
            this.lblNeeds.Text = "NEEDS";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(460, 632);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 49);
            this.btnSave.TabIndex = 105;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBoxUndipLogo
            // 
            this.pictureBoxUndipLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxUndipLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUndipLogo.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Logo;
            this.pictureBoxUndipLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUndipLogo.ErrorImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Logo;
            this.pictureBoxUndipLogo.InitialImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Logo;
            this.pictureBoxUndipLogo.Location = new System.Drawing.Point(914, 15);
            this.pictureBoxUndipLogo.Name = "pictureBoxUndipLogo";
            this.pictureBoxUndipLogo.Size = new System.Drawing.Size(52, 59);
            this.pictureBoxUndipLogo.TabIndex = 103;
            this.pictureBoxUndipLogo.TabStop = false;
            // 
            // FormAddVisitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Gate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 694);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblUndip);
            this.Controls.Add(this.panelAddBook);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBoxUndipLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddVisitors";
            this.Text = "Add Visitors Page";
            this.panelAddBook.ResumeLayout(false);
            this.panelAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUndipLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblDatee;
        private System.Windows.Forms.Label lblNamee;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblStudyProgram;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblUndip;
        private System.Windows.Forms.Panel panelAddBook;
        public System.Windows.Forms.TextBox txtNamee;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.TextBox txtNeeds;
        public System.Windows.Forms.TextBox txtStudyProgram;
        private System.Windows.Forms.Label lblNeeds;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBoxUndipLogo;
        private System.Windows.Forms.RadioButton rbtGenderM;
        private System.Windows.Forms.RadioButton rbtGenderF;
        private System.Windows.Forms.DateTimePicker dateTimePickerVisitors;
    }
}