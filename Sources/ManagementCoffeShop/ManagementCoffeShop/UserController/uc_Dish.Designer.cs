namespace ManagementCoffeShop.UserController
{
    partial class uc_Dish
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
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumber
            // 
            this.lbNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNumber.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(0, 0);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(100, 88);
            this.lbNumber.TabIndex = 0;
            this.lbNumber.Text = "1";
            this.lbNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(106, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(317, 55);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Sữa chua có đường";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(106, 57);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(65, 16);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "x 20.000";
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(204, 57);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTotal.Size = new System.Drawing.Size(214, 16);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "20.000";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(106)))));
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 3);
            this.panel1.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::ManagementCoffeShop.Properties.Resources.icons8_delete_sign;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(390, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 25);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // uc_Dish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbNumber);
            this.Name = "uc_Dish";
            this.Size = new System.Drawing.Size(422, 88);
            this.Load += new System.EventHandler(this.uc_Dish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
    }
}
