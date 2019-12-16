namespace ManagementCoffeShop.UserController
{
    partial class uc_Product
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
            this.btnImage = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.White;
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Location = new System.Drawing.Point(0, 0);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(170, 157);
            this.btnImage.TabIndex = 0;
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lbName
            // 
            this.lbName.AllowDrop = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbName.Location = new System.Drawing.Point(0, 157);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(170, 45);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Bò Nhúng Giấm";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(125)))), ((int)(((byte)(174)))));
            this.lbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPrice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(106, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(65, 32);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "100K";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnImage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uc_Product";
            this.Size = new System.Drawing.Size(170, 202);
            this.Load += new System.EventHandler(this.uc_Product_Load);
            this.Click += new System.EventHandler(this.uc_Product_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
    }
}
