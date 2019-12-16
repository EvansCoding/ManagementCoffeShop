namespace ManagementCoffeShop
{
    partial class FMessageOrderNumber
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbbNumber.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng sản phẩm:";
            // 
            // cbbNumber
            // 
            this.cbbNumber.Location = new System.Drawing.Point(182, 44);
            this.cbbNumber.Name = "cbbNumber";
            this.cbbNumber.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNumber.Properties.Appearance.Options.UseFont = true;
            this.cbbNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbNumber.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbNumber.Properties.NullText = "1";
            this.cbbNumber.Size = new System.Drawing.Size(80, 24);
            this.cbbNumber.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(148)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 32);
            this.panel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = global::ManagementCoffeShop.Properties.Resources.icons8_delete_sign;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(243, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Coffee Shop";
            // 
            // btnFinish
            // 
            this.btnFinish.BackgroundImage = global::ManagementCoffeShop.Properties.Resources.checkmark_96px;
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Location = new System.Drawing.Point(0, 75);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(274, 44);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // FMessageOrderNumber
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 119);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbbNumber);
            this.Controls.Add(this.label1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMessageOrderNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMessageOrderNumber";
            ((System.ComponentModel.ISupportInitialize)(this.cbbNumber.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbbNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinish;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}