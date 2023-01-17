
namespace ResaurantReservationSYS
{
    partial class frmAddTable
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
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.lblUpdateTable = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.txtBoxSeats = new System.Windows.Forms.TextBox();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(39, 53);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(74, 13);
            this.lblTableNumber.TabIndex = 0;
            this.lblTableNumber.Text = "Table Number";
            // 
            // lblUpdateTable
            // 
            this.lblUpdateTable.AutoSize = true;
            this.lblUpdateTable.Location = new System.Drawing.Point(40, 85);
            this.lblUpdateTable.Name = "lblUpdateTable";
            this.lblUpdateTable.Size = new System.Drawing.Size(86, 13);
            this.lblUpdateTable.TabIndex = 1;
            this.lblUpdateTable.Text = "Number of Seats";
            this.lblUpdateTable.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(40, 118);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(153, 166);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(126, 23);
            this.btnAddRoom.TabIndex = 3;
            this.btnAddRoom.Text = "Add Table";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(132, 46);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumber.TabIndex = 4;
            this.txtBoxNumber.TextChanged += new System.EventHandler(this.txtBoxNumber_TextChanged);
            // 
            // txtBoxSeats
            // 
            this.txtBoxSeats.Location = new System.Drawing.Point(132, 82);
            this.txtBoxSeats.Name = "txtBoxSeats";
            this.txtBoxSeats.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSeats.TabIndex = 5;
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Location = new System.Drawing.Point(132, 118);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLocation.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 235);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.txtBoxSeats);
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblUpdateTable);
            this.Controls.Add(this.lblTableNumber);
            this.Name = "frmAddTable";
            this.Text = "Add Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Label lblUpdateTable;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.TextBox txtBoxSeats;
        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.Button btnCancel;
    }
}