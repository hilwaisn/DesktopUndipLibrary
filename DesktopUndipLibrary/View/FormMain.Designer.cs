namespace DesktopUndipLibrary.View
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxAccount = new System.Windows.Forms.PictureBox();
            this.pictureBoxUndipLogo = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUndip = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnVisitors = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.pictureBoxVisitors = new System.Windows.Forms.PictureBox();
            this.pictureBoxMember = new System.Windows.Forms.PictureBox();
            this.pictureBoxBook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUndipLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAccount
            // 
            this.pictureBoxAccount.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAccount.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Account1;
            this.pictureBoxAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAccount.Location = new System.Drawing.Point(35, 77);
            this.pictureBoxAccount.Name = "pictureBoxAccount";
            this.pictureBoxAccount.Size = new System.Drawing.Size(149, 156);
            this.pictureBoxAccount.TabIndex = 46;
            this.pictureBoxAccount.TabStop = false;
            // 
            // pictureBoxUndipLogo
            // 
            this.pictureBoxUndipLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUndipLogo.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Logo;
            this.pictureBoxUndipLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUndipLogo.ErrorImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Logo;
            this.pictureBoxUndipLogo.InitialImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Logo;
            this.pictureBoxUndipLogo.Location = new System.Drawing.Point(913, 15);
            this.pictureBoxUndipLogo.Name = "pictureBoxUndipLogo";
            this.pictureBoxUndipLogo.Size = new System.Drawing.Size(52, 59);
            this.pictureBoxUndipLogo.TabIndex = 45;
            this.pictureBoxUndipLogo.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(935, 618);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 40);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUndip
            // 
            this.lblUndip.AutoSize = true;
            this.lblUndip.BackColor = System.Drawing.Color.Transparent;
            this.lblUndip.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUndip.Location = new System.Drawing.Point(179, 15);
            this.lblUndip.Name = "lblUndip";
            this.lblUndip.Size = new System.Drawing.Size(730, 59);
            this.lblUndip.TabIndex = 39;
            this.lblUndip.Text = "DIPONEGORO UNIVERSITY LIBRARY";
            this.lblUndip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTransaction.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.Location = new System.Drawing.Point(1, 590);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(230, 90);
            this.btnTransaction.TabIndex = 37;
            this.btnTransaction.Text = "TRANSACTION";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnVisitors
            // 
            this.btnVisitors.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVisitors.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitors.Location = new System.Drawing.Point(1, 335);
            this.btnVisitors.Name = "btnVisitors";
            this.btnVisitors.Size = new System.Drawing.Size(230, 90);
            this.btnVisitors.TabIndex = 36;
            this.btnVisitors.Text = "VISITORS";
            this.btnVisitors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisitors.UseVisualStyleBackColor = false;
            this.btnVisitors.Click += new System.EventHandler(this.btnVisitors_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdmin.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(1, 251);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(230, 90);
            this.btnAdmin.TabIndex = 35;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMember.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.Location = new System.Drawing.Point(1, 421);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(230, 90);
            this.btnMember.TabIndex = 34;
            this.btnMember.Text = "MEMBER";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBook.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(1, 506);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(230, 90);
            this.btnBook.TabIndex = 33;
            this.btnBook.Text = "BOOK";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // pictureBoxAdmin
            // 
            this.pictureBoxAdmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxAdmin.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Account1;
            this.pictureBoxAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAdmin.Location = new System.Drawing.Point(12, 266);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(63, 61);
            this.pictureBoxAdmin.TabIndex = 47;
            this.pictureBoxAdmin.TabStop = false;
            // 
            // pictureBoxVisitors
            // 
            this.pictureBoxVisitors.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxVisitors.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Visitors;
            this.pictureBoxVisitors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxVisitors.Location = new System.Drawing.Point(12, 353);
            this.pictureBoxVisitors.Name = "pictureBoxVisitors";
            this.pictureBoxVisitors.Size = new System.Drawing.Size(75, 56);
            this.pictureBoxVisitors.TabIndex = 48;
            this.pictureBoxVisitors.TabStop = false;
            // 
            // pictureBoxMember
            // 
            this.pictureBoxMember.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxMember.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Member;
            this.pictureBoxMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMember.Location = new System.Drawing.Point(12, 441);
            this.pictureBoxMember.Name = "pictureBoxMember";
            this.pictureBoxMember.Size = new System.Drawing.Size(78, 50);
            this.pictureBoxMember.TabIndex = 49;
            this.pictureBoxMember.TabStop = false;
            // 
            // pictureBoxBook
            // 
            this.pictureBoxBook.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxBook.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Book;
            this.pictureBoxBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBook.Location = new System.Drawing.Point(15, 522);
            this.pictureBoxBook.Name = "pictureBoxBook";
            this.pictureBoxBook.Size = new System.Drawing.Size(63, 56);
            this.pictureBoxBook.TabIndex = 50;
            this.pictureBoxBook.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Horse_Statue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 694);
            this.Controls.Add(this.pictureBoxBook);
            this.Controls.Add(this.pictureBoxMember);
            this.Controls.Add(this.pictureBoxVisitors);
            this.Controls.Add(this.pictureBoxAdmin);
            this.Controls.Add(this.pictureBoxAccount);
            this.Controls.Add(this.pictureBoxUndipLogo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblUndip);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnVisitors);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUndipLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAccount;
        private System.Windows.Forms.PictureBox pictureBoxUndipLogo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUndip;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnVisitors;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private System.Windows.Forms.PictureBox pictureBoxVisitors;
        private System.Windows.Forms.PictureBox pictureBoxMember;
        private System.Windows.Forms.PictureBox pictureBoxBook;
    }
}