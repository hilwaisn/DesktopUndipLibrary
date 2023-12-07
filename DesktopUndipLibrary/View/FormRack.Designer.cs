namespace DesktopUndipLibrary.View
{
    partial class FormRack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRack));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelAddBook = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNamee = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dataGridViewRack = new System.Windows.Forms.DataGridView();
            this.panelAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(79, 608);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 49);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(362, 608);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 49);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(814, 611);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 46);
            this.btnCancel.TabIndex = 97;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(661, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 50);
            this.btnSave.TabIndex = 99;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelAddBook
            // 
            this.panelAddBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAddBook.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAddBook.Controls.Add(this.txtName);
            this.panelAddBook.Controls.Add(this.lblNamee);
            this.panelAddBook.Controls.Add(this.txtId);
            this.panelAddBook.Controls.Add(this.lblId);
            this.panelAddBook.Location = new System.Drawing.Point(563, 112);
            this.panelAddBook.Name = "panelAddBook";
            this.panelAddBook.Size = new System.Drawing.Size(366, 206);
            this.panelAddBook.TabIndex = 98;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(154, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 42);
            this.txtName.TabIndex = 14;
            // 
            // lblNamee
            // 
            this.lblNamee.AutoSize = true;
            this.lblNamee.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamee.Location = new System.Drawing.Point(19, 102);
            this.lblNamee.Name = "lblNamee";
            this.lblNamee.Size = new System.Drawing.Size(88, 35);
            this.lblNamee.TabIndex = 4;
            this.lblNamee.Text = "NAME";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(154, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(191, 42);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(19, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 35);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // dataGridViewRack
            // 
            this.dataGridViewRack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewRack.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewRack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRack.Location = new System.Drawing.Point(51, 43);
            this.dataGridViewRack.Name = "dataGridViewRack";
            this.dataGridViewRack.RowHeadersWidth = 62;
            this.dataGridViewRack.RowTemplate.Height = 28;
            this.dataGridViewRack.Size = new System.Drawing.Size(472, 534);
            this.dataGridViewRack.TabIndex = 0;
            this.dataGridViewRack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRack_CellClick);
            // 
            // FormRack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopUndipLibrary.Properties.Resources.Undip_Alley_Entrance_Gate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelAddBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewRack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRack";
            this.Text = "Rack Page";
            this.Load += new System.EventHandler(this.FormRack_Load);
            this.panelAddBook.ResumeLayout(false);
            this.panelAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelAddBook;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNamee;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dataGridViewRack;
    }
}