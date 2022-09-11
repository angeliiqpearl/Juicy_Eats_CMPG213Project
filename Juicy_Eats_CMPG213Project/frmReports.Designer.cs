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
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.rbInventory = new System.Windows.Forms.RadioButton();
            this.rbSales = new System.Windows.Forms.RadioButton();
            this.gbTotals = new System.Windows.Forms.GroupBox();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.gbDetails.SuspendLayout();
            this.gbTotals.SuspendLayout();
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
            this.lblHeading.Location = new System.Drawing.Point(308, 36);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(184, 25);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "VIEW REPORTS";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.rbSales);
            this.gbDetails.Controls.Add(this.rbInventory);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(28, 118);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(200, 100);
            this.gbDetails.TabIndex = 3;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details of the report";
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
            this.rbInventory.CheckedChanged += new System.EventHandler(this.rbInventory_CheckedChanged);
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
            this.rbSales.CheckedChanged += new System.EventHandler(this.rbSales_CheckedChanged);
            // 
            // gbTotals
            // 
            this.gbTotals.Controls.Add(this.rbNo);
            this.gbTotals.Controls.Add(this.rbYes);
            this.gbTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotals.Location = new System.Drawing.Point(345, 118);
            this.gbTotals.Name = "gbTotals";
            this.gbTotals.Size = new System.Drawing.Size(200, 100);
            this.gbTotals.TabIndex = 4;
            this.gbTotals.TabStop = false;
            this.gbTotals.Text = "Show total for sales report";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(17, 29);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(51, 22);
            this.rbYes.TabIndex = 0;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(17, 63);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(46, 22);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.gbTotals);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbTotals.ResumeLayout(false);
            this.gbTotals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.RadioButton rbSales;
        private System.Windows.Forms.RadioButton rbInventory;
        private System.Windows.Forms.GroupBox gbTotals;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
    }
}