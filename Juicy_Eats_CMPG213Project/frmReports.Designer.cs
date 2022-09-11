namespace Juicy_Eats_CMPG213Project
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInventory = new System.Windows.Forms.RadioButton();
            this.rbSales = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(482, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 44);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(631, 367);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 44);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Report";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(30, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(184, 25);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "VIEW REPORTS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSales);
            this.groupBox1.Controls.Add(this.rbInventory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details of the report";
            // 
            // rbInventory
            // 
            this.rbInventory.AutoSize = true;
            this.rbInventory.Location = new System.Drawing.Point(7, 29);
            this.rbInventory.Name = "rbInventory";
            this.rbInventory.Size = new System.Drawing.Size(85, 22);
            this.rbInventory.TabIndex = 0;
            this.rbInventory.TabStop = true;
            this.rbInventory.Text = "Inventory";
            this.rbInventory.UseVisualStyleBackColor = true;
            // 
            // rbSales
            // 
            this.rbSales.AutoSize = true;
            this.rbSales.Location = new System.Drawing.Point(7, 63);
            this.rbSales.Name = "rbSales";
            this.rbSales.Size = new System.Drawing.Size(63, 22);
            this.rbSales.TabIndex = 1;
            this.rbSales.TabStop = true;
            this.rbSales.Text = "Sales";
            this.rbSales.UseVisualStyleBackColor = true;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSales;
        private System.Windows.Forms.RadioButton rbInventory;
    }
}