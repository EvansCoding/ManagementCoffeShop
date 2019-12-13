namespace ManagementCoffeShop.UserController
{
    partial class uc_Table
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmtDISH = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.orderProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTable = new System.Windows.Forms.ToolStripMenuItem();
            this.cmtDISH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(190)))), ((int)(((byte)(238)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 5);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.ContextMenuStrip = this.cmtDISH;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmtDISH
            // 
            this.cmtDISH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderProduct,
            this.deleteTable});
            this.cmtDISH.Name = "cmtDISH";
            this.cmtDISH.Size = new System.Drawing.Size(181, 70);
            // 
            // orderProduct
            // 
            this.orderProduct.Image = global::ManagementCoffeShop.Properties.Resources.icons8_restaurant_32;
            this.orderProduct.Name = "orderProduct";
            this.orderProduct.Size = new System.Drawing.Size(180, 22);
            this.orderProduct.Text = "Gọi Món";
            this.orderProduct.Click += new System.EventHandler(this.orderProduct_Click);
            // 
            // deleteTable
            // 
            this.deleteTable.Image = global::ManagementCoffeShop.Properties.Resources.icons8_delete_property_32;
            this.deleteTable.Name = "deleteTable";
            this.deleteTable.Size = new System.Drawing.Size(180, 22);
            this.deleteTable.Text = "Hủy Bàn";
            // 
            // uc_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(12, 12, 12, 2);
            this.Name = "uc_Table";
            this.Size = new System.Drawing.Size(124, 117);
            this.Load += new System.EventHandler(this.uc_Table_Load);
            this.Click += new System.EventHandler(this.uc_Table_Click);
            this.cmtDISH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmtDISH;
        private System.Windows.Forms.ToolStripMenuItem orderProduct;
        private System.Windows.Forms.ToolStripMenuItem deleteTable;
    }
}
