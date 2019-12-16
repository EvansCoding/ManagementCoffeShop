namespace ManagementCoffeShop.UserController
{
    partial class uc_KindProduct
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
            this.lbNameProductType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBelow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbNameProductType
            // 
            this.lbNameProductType.BackColor = System.Drawing.Color.White;
            this.lbNameProductType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNameProductType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameProductType.Location = new System.Drawing.Point(0, 0);
            this.lbNameProductType.Name = "lbNameProductType";
            this.lbNameProductType.Padding = new System.Windows.Forms.Padding(10);
            this.lbNameProductType.Size = new System.Drawing.Size(170, 51);
            this.lbNameProductType.TabIndex = 0;
            this.lbNameProductType.Text = "Trà Sửa";
            this.lbNameProductType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNameProductType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbNameProductType_MouseClick);
            this.lbNameProductType.MouseLeave += new System.EventHandler(this.lbNameProductType_MouseLeave);
            this.lbNameProductType.MouseHover += new System.EventHandler(this.lbNameProductType_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 1);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(1)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 52);
            this.panel2.TabIndex = 2;
            // 
            // pnlBelow
            // 
            this.pnlBelow.BackColor = System.Drawing.Color.White;
            this.pnlBelow.Location = new System.Drawing.Point(5, 47);
            this.pnlBelow.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBelow.Name = "pnlBelow";
            this.pnlBelow.Size = new System.Drawing.Size(165, 4);
            this.pnlBelow.TabIndex = 3;
            // 
            // uc_KindProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBelow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbNameProductType);
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "uc_KindProduct";
            this.Size = new System.Drawing.Size(170, 52);
            this.Load += new System.EventHandler(this.uc_KindProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNameProductType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBelow;
    }
}
