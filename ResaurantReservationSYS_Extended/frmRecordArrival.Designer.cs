
namespace ResaurantReservationSYS
{
    partial class frmRecordArrival
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
            this.txtResId = new System.Windows.Forms.TextBox();
            this.lblResId = new System.Windows.Forms.Label();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTableNo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtResId
            // 
            this.txtResId.Location = new System.Drawing.Point(131, 12);
            this.txtResId.Name = "txtResId";
            this.txtResId.Size = new System.Drawing.Size(100, 20);
            this.txtResId.TabIndex = 0;
            // 
            // lblResId
            // 
            this.lblResId.AutoSize = true;
            this.lblResId.Location = new System.Drawing.Point(47, 15);
            this.lblResId.Name = "lblResId";
            this.lblResId.Size = new System.Drawing.Size(78, 13);
            this.lblResId.TabIndex = 1;
            this.lblResId.Text = "Reservation ID";
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Location = new System.Drawing.Point(47, 59);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(74, 13);
            this.lblTableNo.TabIndex = 2;
            this.lblTableNo.Text = "Table Number";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(51, 106);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname";
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(131, 103);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSurname.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(25, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(118, 181);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(212, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTableNo
            // 
            this.txtTableNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTableNo.FormattingEnabled = true;
            this.txtTableNo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05"});
            this.txtTableNo.Location = new System.Drawing.Point(131, 56);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.Size = new System.Drawing.Size(100, 21);
            this.txtTableNo.TabIndex = 9;
            // 
            // frmRecordArrival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 288);
            this.Controls.Add(this.txtTableNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblTableNo);
            this.Controls.Add(this.lblResId);
            this.Controls.Add(this.txtResId);
            this.Name = "frmRecordArrival";
            this.Text = "Record Arrival";
            this.Load += new System.EventHandler(this.frmRecordArrival_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResId;
        private System.Windows.Forms.Label lblResId;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox txtTableNo;
    }
}