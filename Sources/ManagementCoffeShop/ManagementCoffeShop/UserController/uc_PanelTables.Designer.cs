namespace ManagementCoffeShop.UserController
{
    partial class uc_PanelTables
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAreaVIP = new System.Windows.Forms.Button();
            this.btnAreaNormal = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.btnAreaVIP);
            this.panel2.Controls.Add(this.btnAreaNormal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 41);
            this.panel2.TabIndex = 2;
            // 
            // btnAreaVIP
            // 
            this.btnAreaVIP.FlatAppearance.BorderSize = 0;
            this.btnAreaVIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreaVIP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaVIP.ForeColor = System.Drawing.Color.White;
            this.btnAreaVIP.Location = new System.Drawing.Point(129, 0);
            this.btnAreaVIP.Name = "btnAreaVIP";
            this.btnAreaVIP.Size = new System.Drawing.Size(117, 41);
            this.btnAreaVIP.TabIndex = 1;
            this.btnAreaVIP.Text = "VIP";
            this.btnAreaVIP.UseVisualStyleBackColor = true;
            this.btnAreaVIP.Click += new System.EventHandler(this.btnAreaVIP_Click);
            // 
            // btnAreaNormal
            // 
            this.btnAreaNormal.FlatAppearance.BorderSize = 0;
            this.btnAreaNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreaNormal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaNormal.ForeColor = System.Drawing.Color.White;
            this.btnAreaNormal.Location = new System.Drawing.Point(6, 0);
            this.btnAreaNormal.Name = "btnAreaNormal";
            this.btnAreaNormal.Size = new System.Drawing.Size(117, 41);
            this.btnAreaNormal.TabIndex = 0;
            this.btnAreaNormal.Text = "THƯỜNG";
            this.btnAreaNormal.UseVisualStyleBackColor = true;
            this.btnAreaNormal.Click += new System.EventHandler(this.btnAreaNormal_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 41);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(712, 627);
            this.pnlControl.TabIndex = 3;
            // 
            // uc_PanelTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.panel2);
            this.Name = "uc_PanelTables";
            this.Size = new System.Drawing.Size(712, 668);
            this.Load += new System.EventHandler(this.uc_Tables_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAreaVIP;
        private System.Windows.Forms.Button btnAreaNormal;
        private System.Windows.Forms.Panel pnlControl;
    }
}
