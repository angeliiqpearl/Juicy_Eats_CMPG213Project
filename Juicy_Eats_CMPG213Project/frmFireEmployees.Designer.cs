namespace Juicy_Eats_CMPG213Project
{
    partial class frmFireEmployees
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
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnFire = new System.Windows.Forms.Button();
            this.cmbSurname = new System.Windows.Forms.ComboBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbName
            // 
            this.cmbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(80, 80);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(191, 28);
            this.cmbName.TabIndex = 0;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(76, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(178, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Select Employee Name:";
            this.lblName.Click += new System.EventHandler(this.lblSelect_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(37, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(277, 29);
            this.lblHeading.TabIndex = 11;
            this.lblHeading.Text = "Employee Termination";
            // 
            // btnFire
            // 
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(92, 206);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(149, 35);
            this.btnFire.TabIndex = 2;
            this.btnFire.Text = "Fire Employee";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // cmbSurname
            // 
            this.cmbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSurname.FormattingEnabled = true;
            this.cmbSurname.Location = new System.Drawing.Point(80, 147);
            this.cmbSurname.Name = "cmbSurname";
            this.cmbSurname.Size = new System.Drawing.Size(191, 28);
            this.cmbSurname.TabIndex = 1;
            this.cmbSurname.SelectedIndexChanged += new System.EventHandler(this.cmbSurname_SelectedIndexChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(76, 124);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(201, 20);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Select Employee Surname:";
            // 
            // frmFireEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 275);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.cmbSurname);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbName);
            this.Name = "frmFireEmployees";
            this.Text = "frmFireEmployees";
            this.Load += new System.EventHandler(this.frmFireEmployees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.ComboBox cmbSurname;
        private System.Windows.Forms.Label lblSurname;
    }
}