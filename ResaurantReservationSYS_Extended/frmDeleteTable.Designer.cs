
namespace ResaurantReservationSYS
{
    partial class frmDeleteTable
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboBoxNumber = new System.Windows.Forms.ComboBox();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.grpBoxDescription = new System.Windows.Forms.GroupBox();
            this.txtBoxReason = new System.Windows.Forms.TextBox();
            this.grpBoxDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(32, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboBoxNumber
            // 
            this.cboBoxNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxNumber.FormattingEnabled = true;
            this.cboBoxNumber.Items.AddRange(new object[] {
            "15",
            "33",
            "05"});
            this.cboBoxNumber.Location = new System.Drawing.Point(122, 31);
            this.cboBoxNumber.Name = "cboBoxNumber";
            this.cboBoxNumber.Size = new System.Drawing.Size(100, 21);
            this.cboBoxNumber.TabIndex = 22;
            this.cboBoxNumber.TextChanged += new System.EventHandler(this.cboBoxNumber_TextChanged);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(164, 223);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(126, 23);
            this.btnDeleteTable.TabIndex = 19;
            this.btnDeleteTable.Text = "Delete Table";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(29, 34);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(74, 13);
            this.lblTableNumber.TabIndex = 16;
            this.lblTableNumber.Text = "Table Number";
            // 
            // grpBoxDescription
            // 
            this.grpBoxDescription.Controls.Add(this.txtBoxReason);
            this.grpBoxDescription.Location = new System.Drawing.Point(49, 87);
            this.grpBoxDescription.Name = "grpBoxDescription";
            this.grpBoxDescription.Size = new System.Drawing.Size(200, 121);
            this.grpBoxDescription.TabIndex = 24;
            this.grpBoxDescription.TabStop = false;
            this.grpBoxDescription.Text = "Reason";
            // 
            // txtBoxReason
            // 
            this.txtBoxReason.Location = new System.Drawing.Point(9, 19);
            this.txtBoxReason.Multiline = true;
            this.txtBoxReason.Name = "txtBoxReason";
            this.txtBoxReason.Size = new System.Drawing.Size(185, 96);
            this.txtBoxReason.TabIndex = 25;
            // 
            // frmDeleteTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 329);
            this.Controls.Add(this.grpBoxDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboBoxNumber);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.lblTableNumber);
            this.Name = "frmDeleteTable";
            this.Text = "frmDeleteTable";
            this.grpBoxDescription.ResumeLayout(false);
            this.grpBoxDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboBoxNumber;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.GroupBox grpBoxDescription;
        private System.Windows.Forms.TextBox txtBoxReason;
    }
}