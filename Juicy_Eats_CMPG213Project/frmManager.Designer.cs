namespace Juicy_Eats_CMPG213Project
{
    partial class frmManager
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeDetailsStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(291, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(239, 29);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "Juicy Eats Manager";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeesToolStripMenuItem,
            this.hireEmployeesToolStripMenuItem,
            this.fireEmployeesToolStripMenuItem,
            this.updateEmployeeDetailsStatusToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInventoryToolStripMenuItem,
            this.purchaseInventoryToolStripMenuItem,
            this.deleteInventoryToolStripMenuItem,
            this.updateInventoryToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSuppliersToolStripMenuItem,
            this.addSuppliersToolStripMenuItem,
            this.deleteSuppliersToolStripMenuItem});
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // requestReportsToolStripMenuItem
            // 
            this.requestReportsToolStripMenuItem.Name = "requestReportsToolStripMenuItem";
            this.requestReportsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.requestReportsToolStripMenuItem.Text = "Request Reports";
            // 
            // viewSuppliersToolStripMenuItem
            // 
            this.viewSuppliersToolStripMenuItem.Name = "viewSuppliersToolStripMenuItem";
            this.viewSuppliersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewSuppliersToolStripMenuItem.Text = "View Suppliers";
            // 
            // addSuppliersToolStripMenuItem
            // 
            this.addSuppliersToolStripMenuItem.Name = "addSuppliersToolStripMenuItem";
            this.addSuppliersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addSuppliersToolStripMenuItem.Text = "Add Suppliers";
            this.addSuppliersToolStripMenuItem.Click += new System.EventHandler(this.addSuppliersToolStripMenuItem_Click);
            // 
            // deleteSuppliersToolStripMenuItem
            // 
            this.deleteSuppliersToolStripMenuItem.Name = "deleteSuppliersToolStripMenuItem";
            this.deleteSuppliersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteSuppliersToolStripMenuItem.Text = "Delete Suppliers";
            this.deleteSuppliersToolStripMenuItem.Click += new System.EventHandler(this.deleteSuppliersToolStripMenuItem_Click);
            // 
            // viewInventoryToolStripMenuItem
            // 
            this.viewInventoryToolStripMenuItem.Name = "viewInventoryToolStripMenuItem";
            this.viewInventoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewInventoryToolStripMenuItem.Text = "View Inventory";
            // 
            // purchaseInventoryToolStripMenuItem
            // 
            this.purchaseInventoryToolStripMenuItem.Name = "purchaseInventoryToolStripMenuItem";
            this.purchaseInventoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.purchaseInventoryToolStripMenuItem.Text = "Purchase Inventory";
            this.purchaseInventoryToolStripMenuItem.Click += new System.EventHandler(this.purchaseInventoryToolStripMenuItem_Click);
            // 
            // updateInventoryToolStripMenuItem
            // 
            this.updateInventoryToolStripMenuItem.Name = "updateInventoryToolStripMenuItem";
            this.updateInventoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateInventoryToolStripMenuItem.Text = "Update Inventory";
            // 
            // deleteInventoryToolStripMenuItem
            // 
            this.deleteInventoryToolStripMenuItem.Name = "deleteInventoryToolStripMenuItem";
            this.deleteInventoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteInventoryToolStripMenuItem.Text = "Delete Inventory";
            this.deleteInventoryToolStripMenuItem.Click += new System.EventHandler(this.deleteInventoryToolStripMenuItem_Click);
            // 
            // hireEmployeesToolStripMenuItem
            // 
            this.hireEmployeesToolStripMenuItem.Name = "hireEmployeesToolStripMenuItem";
            this.hireEmployeesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.hireEmployeesToolStripMenuItem.Text = "Hire Employees";
            this.hireEmployeesToolStripMenuItem.Click += new System.EventHandler(this.hireEmployeesToolStripMenuItem_Click);
            // 
            // fireEmployeesToolStripMenuItem
            // 
            this.fireEmployeesToolStripMenuItem.Name = "fireEmployeesToolStripMenuItem";
            this.fireEmployeesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.fireEmployeesToolStripMenuItem.Text = "Fire Employees";
            this.fireEmployeesToolStripMenuItem.Click += new System.EventHandler(this.fireEmployeesToolStripMenuItem_Click);
            // 
            // updateEmployeeDetailsStatusToolStripMenuItem
            // 
            this.updateEmployeeDetailsStatusToolStripMenuItem.Name = "updateEmployeeDetailsStatusToolStripMenuItem";
            this.updateEmployeeDetailsStatusToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.updateEmployeeDetailsStatusToolStripMenuItem.Text = "Update Employee Details/Status";
            // 
            // viewEmployeesToolStripMenuItem
            // 
            this.viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            this.viewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.viewEmployeesToolStripMenuItem.Text = "View Employees";
            this.viewEmployeesToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeesToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 339);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(724, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(79, 29);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 422);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmManager";
            this.Text = "Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeDetailsStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestReportsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLogout;
    }
}