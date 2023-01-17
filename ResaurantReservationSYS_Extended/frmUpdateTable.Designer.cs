
namespace ResaurantReservationSYS
{
    partial class frmUpdateTable
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
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.txtBoxSeats = new System.Windows.Forms.TextBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblUpdateTable = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.cboBoxNumber = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Location = new System.Drawing.Point(116, 109);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLocation.TabIndex = 13;
            // 
            // txtBoxSeats
            // 
            this.txtBoxSeats.Location = new System.Drawing.Point(116, 73);
            this.txtBoxSeats.Name = "txtBoxSeats";
            this.txtBoxSeats.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSeats.TabIndex = 12;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(157, 159);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(126, 23);
            this.btnAddRoom.TabIndex = 10;
            this.btnAddRoom.Text = "Update Table";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(24, 109);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 9;
            this.lblLocation.Text = "Location";
            // 
            // lblUpdateTable
            // 
            this.lblUpdateTable.AutoSize = true;
            this.lblUpdateTable.Location = new System.Drawing.Point(24, 76);
            this.lblUpdateTable.Name = "lblUpdateTable";
            this.lblUpdateTable.Size = new System.Drawing.Size(86, 13);
            this.lblUpdateTable.TabIndex = 8;
            this.lblUpdateTable.Text = "Number of Seats";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(23, 44);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(74, 13);
            this.lblTableNumber.TabIndex = 7;
            this.lblTableNumber.Text = "Table Number";
            // 
            // cboBoxNumber
            // 
            this.cboBoxNumber.FormattingEnabled = true;
            this.cboBoxNumber.Location = new System.Drawing.Point(116, 41);
            this.cboBoxNumber.Name = "cboBoxNumber";
            this.cboBoxNumber.Size = new System.Drawing.Size(100, 21);
            this.cboBoxNumber.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmUpdateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 225);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboBoxNumber);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.txtBoxSeats);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblUpdateTable);
            this.Controls.Add(this.lblTableNumber);
            this.Name = "frmUpdateTable";
            this.Text = "frmUpdateTable";
            this.Load += new System.EventHandler(this.frmUpdateTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.TextBox txtBoxSeats;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblUpdateTable;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.ComboBox cboBoxNumber;
        private System.Windows.Forms.Button btnCancel;
    }
}