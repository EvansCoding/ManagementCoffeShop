namespace ManagementCoffeShop
{
    partial class fAddSupplier
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
            this.stackPanel = new DevExpress.Utils.Layout.StackPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLogin = new DevExpress.XtraEditors.LabelControl();
            this.tbName = new DevExpress.XtraEditors.TextEdit();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.buttonStackPanel = new DevExpress.Utils.Layout.StackPanel();
            this.btnLogIn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.defaultLookAndFeel2 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbAddress = new DevExpress.XtraEditors.TextEdit();
            this.tbPhone = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel)).BeginInit();
            this.stackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStackPanel)).BeginInit();
            this.buttonStackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhone.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // stackPanel
            // 
            this.stackPanel.Appearance.BackColor = System.Drawing.Color.White;
            this.stackPanel.Appearance.Options.UseBackColor = true;
            this.stackPanel.Controls.Add(this.panel1);
            this.stackPanel.Controls.Add(this.labelLogin);
            this.stackPanel.Controls.Add(this.tbName);
            this.stackPanel.Controls.Add(this.labelPassword);
            this.stackPanel.Controls.Add(this.tbAddress);
            this.stackPanel.Controls.Add(this.labelControl1);
            this.stackPanel.Controls.Add(this.tbPhone);
            this.stackPanel.Controls.Add(this.buttonStackPanel);
            this.stackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel.Location = new System.Drawing.Point(0, 0);
            this.stackPanel.Name = "stackPanel";
            this.stackPanel.Size = new System.Drawing.Size(298, 268);
            this.stackPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 25);
            this.panel1.TabIndex = 8;
            // 
            // labelLogin
            // 
            this.labelLogin.Appearance.FontSizeDelta = 2;
            this.labelLogin.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLogin.Appearance.Options.UseFont = true;
            this.labelLogin.Appearance.Options.UseForeColor = true;
            this.labelLogin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelLogin.Location = new System.Drawing.Point(42, 34);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(214, 17);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Tên Nhà Cung Cấp";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(42, 54);
            this.tbName.Name = "tbName";
            this.tbName.Properties.Appearance.FontSizeDelta = 4;
            this.tbName.Properties.Appearance.Options.UseFont = true;
            this.tbName.Size = new System.Drawing.Size(214, 26);
            this.tbName.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.Appearance.FontSizeDelta = 2;
            this.labelPassword.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPassword.Appearance.Options.UseFont = true;
            this.labelPassword.Appearance.Options.UseForeColor = true;
            this.labelPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelPassword.Location = new System.Drawing.Point(42, 90);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(214, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Địa Chỉ";
            // 
            // buttonStackPanel
            // 
            this.buttonStackPanel.Controls.Add(this.btnLogIn);
            this.buttonStackPanel.Controls.Add(this.simpleButton1);
            this.buttonStackPanel.Location = new System.Drawing.Point(42, 215);
            this.buttonStackPanel.Margin = new System.Windows.Forms.Padding(20);
            this.buttonStackPanel.Name = "buttonStackPanel";
            this.buttonStackPanel.Size = new System.Drawing.Size(214, 40);
            this.buttonStackPanel.TabIndex = 6;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(0, 7);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(107, 26);
            this.buttonStackPanel.SetStretched(this.btnLogIn, true);
            this.btnLogIn.TabIndex = 1;
            this.btnLogIn.Text = "Thêm";
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(107, 7);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(107, 26);
            this.buttonStackPanel.SetStretched(this.simpleButton1, true);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Colorful";
            // 
            // defaultLookAndFeel2
            // 
            this.defaultLookAndFeel2.LookAndFeel.SkinName = "Office 2019 Colorful";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.FontSizeDelta = 2;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(42, 146);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(214, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Số Điện Thoại";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(42, 110);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Properties.Appearance.FontSizeDelta = 4;
            this.tbAddress.Properties.Appearance.Options.UseFont = true;
            this.tbAddress.Size = new System.Drawing.Size(214, 26);
            this.tbAddress.TabIndex = 12;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(42, 166);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Properties.Appearance.FontSizeDelta = 4;
            this.tbPhone.Properties.Appearance.Options.UseFont = true;
            this.tbPhone.Size = new System.Drawing.Size(214, 26);
            this.tbPhone.TabIndex = 13;
            // 
            // fAddSupplier
            // 
            this.AcceptButton = this.btnLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.stackPanel);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel)).EndInit();
            this.stackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStackPanel)).EndInit();
            this.buttonStackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhone.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel stackPanel;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelLogin;
        private DevExpress.XtraEditors.TextEdit tbName;
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.XtraEditors.TextEdit tbAddress;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbPhone;
        private DevExpress.Utils.Layout.StackPanel buttonStackPanel;
        private DevExpress.XtraEditors.SimpleButton btnLogIn;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel2;
    }
}