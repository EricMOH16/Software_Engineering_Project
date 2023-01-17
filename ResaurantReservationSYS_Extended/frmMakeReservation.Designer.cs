
namespace ResaurantReservationSYS
{
    partial class frmMakeReservation
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.txtBoxSize = new System.Windows.Forms.TextBox();
            this.bbtnAvailablility = new System.Windows.Forms.Button();
            this.grpBoxTable = new System.Windows.Forms.GroupBox();
            this.listBoxTables = new System.Windows.Forms.ListBox();
            this.grpBoxGuestInfo = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblResId = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxForename = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpBoxTable.SuspendLayout();
            this.grpBoxGuestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(31, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(31, 55);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Party Size";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(98, 17);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Location = new System.Drawing.Point(98, 48);
            this.txtBoxTime.MaxLength = 5;
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTime.TabIndex = 4;
            // 
            // txtBoxSize
            // 
            this.txtBoxSize.Location = new System.Drawing.Point(98, 81);
            this.txtBoxSize.MaxLength = 5;
            this.txtBoxSize.Name = "txtBoxSize";
            this.txtBoxSize.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSize.TabIndex = 5;
            // 
            // bbtnAvailablility
            // 
            this.bbtnAvailablility.Location = new System.Drawing.Point(98, 117);
            this.bbtnAvailablility.Name = "bbtnAvailablility";
            this.bbtnAvailablility.Size = new System.Drawing.Size(133, 23);
            this.bbtnAvailablility.TabIndex = 6;
            this.bbtnAvailablility.Text = "Check Availability";
            this.bbtnAvailablility.UseVisualStyleBackColor = true;
            this.bbtnAvailablility.Click += new System.EventHandler(this.bbtnAvailablility_Click);
            // 
            // grpBoxTable
            // 
            this.grpBoxTable.Controls.Add(this.listBoxTables);
            this.grpBoxTable.Location = new System.Drawing.Point(77, 176);
            this.grpBoxTable.Name = "grpBoxTable";
            this.grpBoxTable.Size = new System.Drawing.Size(200, 147);
            this.grpBoxTable.TabIndex = 7;
            this.grpBoxTable.TabStop = false;
            this.grpBoxTable.Text = "Select a Table";
            this.grpBoxTable.Visible = false;
            // 
            // listBoxTables
            // 
            this.listBoxTables.FormattingEnabled = true;
            this.listBoxTables.Location = new System.Drawing.Point(21, 19);
            this.listBoxTables.Name = "listBoxTables";
            this.listBoxTables.Size = new System.Drawing.Size(159, 121);
            this.listBoxTables.TabIndex = 8;
            this.listBoxTables.SelectedIndexChanged += new System.EventHandler(this.listBoxTables_SelectedIndexChanged);
            // 
            // grpBoxGuestInfo
            // 
            this.grpBoxGuestInfo.Controls.Add(this.textBox4);
            this.grpBoxGuestInfo.Controls.Add(this.lblResId);
            this.grpBoxGuestInfo.Controls.Add(this.txtBoxEmail);
            this.grpBoxGuestInfo.Controls.Add(this.txtBoxSurname);
            this.grpBoxGuestInfo.Controls.Add(this.txtBoxForename);
            this.grpBoxGuestInfo.Controls.Add(this.btnConfirm);
            this.grpBoxGuestInfo.Controls.Add(this.lblEmail);
            this.grpBoxGuestInfo.Controls.Add(this.lblSurname);
            this.grpBoxGuestInfo.Controls.Add(this.lblForename);
            this.grpBoxGuestInfo.Location = new System.Drawing.Point(77, 338);
            this.grpBoxGuestInfo.Name = "grpBoxGuestInfo";
            this.grpBoxGuestInfo.Size = new System.Drawing.Size(409, 173);
            this.grpBoxGuestInfo.TabIndex = 8;
            this.grpBoxGuestInfo.TabStop = false;
            this.grpBoxGuestInfo.Text = "GuestInfo";
            this.grpBoxGuestInfo.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(325, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(48, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "54652";
            // 
            // lblResId
            // 
            this.lblResId.AutoSize = true;
            this.lblResId.Location = new System.Drawing.Point(312, 16);
            this.lblResId.Name = "lblResId";
            this.lblResId.Size = new System.Drawing.Size(73, 13);
            this.lblResId.TabIndex = 8;
            this.lblResId.Text = "ReservationId";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(100, 93);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(139, 20);
            this.txtBoxEmail.TabIndex = 7;
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(100, 61);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(139, 20);
            this.txtBoxSurname.TabIndex = 6;
            // 
            // txtBoxForename
            // 
            this.txtBoxForename.Location = new System.Drawing.Point(100, 24);
            this.txtBoxForename.Name = "txtBoxForename";
            this.txtBoxForename.Size = new System.Drawing.Size(139, 20);
            this.txtBoxForename.TabIndex = 5;
            this.txtBoxForename.TextChanged += new System.EventHandler(this.txtBoxForename_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(108, 129);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 25);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(18, 61);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(18, 27);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(54, 13);
            this.lblForename.TabIndex = 0;
            this.lblForename.Text = "Forename";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(402, 55);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 619);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpBoxGuestInfo);
            this.Controls.Add(this.grpBoxTable);
            this.Controls.Add(this.bbtnAvailablility);
            this.Controls.Add(this.txtBoxSize);
            this.Controls.Add(this.txtBoxTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Name = "frmMakeReservation";
            this.Text = "frmMakeReservation";
            this.grpBoxTable.ResumeLayout(false);
            this.grpBoxGuestInfo.ResumeLayout(false);
            this.grpBoxGuestInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtBoxTime;
        private System.Windows.Forms.TextBox txtBoxSize;
        private System.Windows.Forms.Button bbtnAvailablility;
        private System.Windows.Forms.GroupBox grpBoxTable;
        private System.Windows.Forms.ListBox listBoxTables;
        private System.Windows.Forms.GroupBox grpBoxGuestInfo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblResId;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxForename;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}