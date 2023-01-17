
namespace ResaurantReservationSYS
{
    partial class frmCancelRes
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
            this.lblResId = new System.Windows.Forms.Label();
            this.lblReasons = new System.Windows.Forms.Label();
            this.cboBoxReason = new System.Windows.Forms.ComboBox();
            this.txtBoxResId = new System.Windows.Forms.TextBox();
            this.grpBoxReason = new System.Windows.Forms.GroupBox();
            this.txtBoxReason = new System.Windows.Forms.RichTextBox();
            this.btnNewRes = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfrim = new System.Windows.Forms.Button();
            this.grpBoxReason.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResId
            // 
            this.lblResId.AutoSize = true;
            this.lblResId.Location = new System.Drawing.Point(36, 33);
            this.lblResId.Name = "lblResId";
            this.lblResId.Size = new System.Drawing.Size(78, 13);
            this.lblResId.TabIndex = 0;
            this.lblResId.Text = "Reservation ID";
            // 
            // lblReasons
            // 
            this.lblReasons.AutoSize = true;
            this.lblReasons.Location = new System.Drawing.Point(36, 64);
            this.lblReasons.Name = "lblReasons";
            this.lblReasons.Size = new System.Drawing.Size(44, 13);
            this.lblReasons.TabIndex = 1;
            this.lblReasons.Text = "Reason";
            // 
            // cboBoxReason
            // 
            this.cboBoxReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxReason.FormattingEnabled = true;
            this.cboBoxReason.Items.AddRange(new object[] {
            "Advice from others",
            "Poor past experience",
            "Bad online review"});
            this.cboBoxReason.Location = new System.Drawing.Point(132, 61);
            this.cboBoxReason.Name = "cboBoxReason";
            this.cboBoxReason.Size = new System.Drawing.Size(193, 21);
            this.cboBoxReason.TabIndex = 2;
            this.cboBoxReason.SelectedIndexChanged += new System.EventHandler(this.cboBoxReason_SelectedIndexChanged);
            // 
            // txtBoxResId
            // 
            this.txtBoxResId.Location = new System.Drawing.Point(132, 30);
            this.txtBoxResId.Name = "txtBoxResId";
            this.txtBoxResId.Size = new System.Drawing.Size(109, 20);
            this.txtBoxResId.TabIndex = 3;
            this.txtBoxResId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpBoxReason
            // 
            this.grpBoxReason.Controls.Add(this.txtBoxReason);
            this.grpBoxReason.Location = new System.Drawing.Point(67, 135);
            this.grpBoxReason.Name = "grpBoxReason";
            this.grpBoxReason.Size = new System.Drawing.Size(234, 127);
            this.grpBoxReason.TabIndex = 4;
            this.grpBoxReason.TabStop = false;
            this.grpBoxReason.Text = "Additional Information";
            this.grpBoxReason.UseCompatibleTextRendering = true;
            // 
            // txtBoxReason
            // 
            this.txtBoxReason.Location = new System.Drawing.Point(17, 19);
            this.txtBoxReason.Name = "txtBoxReason";
            this.txtBoxReason.Size = new System.Drawing.Size(199, 96);
            this.txtBoxReason.TabIndex = 5;
            this.txtBoxReason.Text = "";
            // 
            // btnNewRes
            // 
            this.btnNewRes.Location = new System.Drawing.Point(122, 328);
            this.btnNewRes.Name = "btnNewRes";
            this.btnNewRes.Size = new System.Drawing.Size(119, 23);
            this.btnNewRes.TabIndex = 5;
            this.btnNewRes.Text = "New Reservation?";
            this.btnNewRes.UseVisualStyleBackColor = true;
            this.btnNewRes.Click += new System.EventHandler(this.btnNewRes_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(84, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfrim
            // 
            this.btnConfrim.Location = new System.Drawing.Point(208, 289);
            this.btnConfrim.Name = "btnConfrim";
            this.btnConfrim.Size = new System.Drawing.Size(75, 23);
            this.btnConfrim.TabIndex = 7;
            this.btnConfrim.Text = "Confirm";
            this.btnConfrim.UseVisualStyleBackColor = true;
            this.btnConfrim.Click += new System.EventHandler(this.btnConfrim_Click);
            // 
            // frmCancelRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.btnConfrim);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewRes);
            this.Controls.Add(this.grpBoxReason);
            this.Controls.Add(this.txtBoxResId);
            this.Controls.Add(this.cboBoxReason);
            this.Controls.Add(this.lblReasons);
            this.Controls.Add(this.lblResId);
            this.Name = "frmCancelRes";
            this.Text = "frmCancelRes";
            this.grpBoxReason.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResId;
        private System.Windows.Forms.Label lblReasons;
        private System.Windows.Forms.ComboBox cboBoxReason;
        private System.Windows.Forms.TextBox txtBoxResId;
        private System.Windows.Forms.GroupBox grpBoxReason;
        private System.Windows.Forms.RichTextBox txtBoxReason;
        private System.Windows.Forms.Button btnNewRes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfrim;
    }
}