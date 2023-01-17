
namespace ResaurantReservationSYS
{
    partial class frmRecordBillPayed
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
            this.txtTableNo = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.lblResId = new System.Windows.Forms.Label();
            this.txtResId = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.txtTableNo.Location = new System.Drawing.Point(145, 97);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.Size = new System.Drawing.Size(100, 21);
            this.txtTableNo.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(132, 222);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(39, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(145, 144);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSurname.TabIndex = 14;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(65, 147);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 13;
            this.lblSurname.Text = "Surname";
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Location = new System.Drawing.Point(61, 100);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(74, 13);
            this.lblTableNo.TabIndex = 12;
            this.lblTableNo.Text = "Table Number";
            // 
            // lblResId
            // 
            this.lblResId.AutoSize = true;
            this.lblResId.Location = new System.Drawing.Point(61, 56);
            this.lblResId.Name = "lblResId";
            this.lblResId.Size = new System.Drawing.Size(78, 13);
            this.lblResId.TabIndex = 11;
            this.lblResId.Text = "Reservation ID";
            // 
            // txtResId
            // 
            this.txtResId.Location = new System.Drawing.Point(145, 53);
            this.txtResId.Name = "txtResId";
            this.txtResId.Size = new System.Drawing.Size(100, 20);
            this.txtResId.TabIndex = 10;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(65, 188);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(55, 13);
            this.lblCost.TabIndex = 19;
            this.lblCost.Text = "Total Cost";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(145, 181);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 20;
            // 
            // frmRecordBillPayed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 299);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtTableNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblTableNo);
            this.Controls.Add(this.lblResId);
            this.Controls.Add(this.txtResId);
            this.Name = "frmRecordBillPayed";
            this.Text = "Recod Bill Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtTableNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Label lblResId;
        private System.Windows.Forms.TextBox txtResId;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
    }
}