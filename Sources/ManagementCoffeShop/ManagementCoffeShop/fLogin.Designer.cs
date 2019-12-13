namespace ManagementCoffeShop
{
    partial class fLogin
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.stackPanel = new DevExpress.Utils.Layout.StackPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelCaption = new DevExpress.XtraEditors.LabelControl();
            this.labelLogin = new DevExpress.XtraEditors.LabelControl();
            this.teLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.buttonStackPanel = new DevExpress.Utils.Layout.StackPanel();
            this.btnLogIn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel)).BeginInit();
            this.stackPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStackPanel)).BeginInit();
            this.buttonStackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // stackPanel
            // 
            this.stackPanel.Controls.Add(this.panel1);
            this.stackPanel.Controls.Add(this.labelCaption);
            this.stackPanel.Controls.Add(this.labelLogin);
            this.stackPanel.Controls.Add(this.teLogin);
            this.stackPanel.Controls.Add(this.labelPassword);
            this.stackPanel.Controls.Add(this.tePassword);
            this.stackPanel.Controls.Add(this.buttonStackPanel);
            this.stackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel.Location = new System.Drawing.Point(0, 0);
            this.stackPanel.Name = "stackPanel";
            this.stackPanel.Size = new System.Drawing.Size(361, 337);
            this.stackPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 25);
            this.panel1.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::ManagementCoffeShop.Properties.Resources.icons8_delete_sign;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(333, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelCaption
            // 
            this.labelCaption.Appearance.FontSizeDelta = 8;
            this.labelCaption.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCaption.Appearance.Options.UseFont = true;
            this.labelCaption.Appearance.Options.UseForeColor = true;
            this.labelCaption.Location = new System.Drawing.Point(154, 70);
            this.labelCaption.Margin = new System.Windows.Forms.Padding(8, 39, 8, 17);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(52, 27);
            this.labelCaption.TabIndex = 0;
            this.labelCaption.Text = "Login";
            // 
            // labelLogin
            // 
            this.labelLogin.Appearance.FontSizeDelta = 2;
            this.labelLogin.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLogin.Appearance.Options.UseFont = true;
            this.labelLogin.Appearance.Options.UseForeColor = true;
            this.labelLogin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelLogin.Location = new System.Drawing.Point(73, 117);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(214, 17);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login";
            // 
            // teLogin
            // 
            this.teLogin.Location = new System.Drawing.Point(73, 137);
            this.teLogin.Name = "teLogin";
            this.teLogin.Properties.Appearance.FontSizeDelta = 4;
            this.teLogin.Properties.Appearance.Options.UseFont = true;
            this.teLogin.Size = new System.Drawing.Size(214, 26);
            this.teLogin.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.Appearance.FontSizeDelta = 2;
            this.labelPassword.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPassword.Appearance.Options.UseFont = true;
            this.labelPassword.Appearance.Options.UseForeColor = true;
            this.labelPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelPassword.Location = new System.Drawing.Point(73, 173);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(214, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(73, 193);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.Appearance.FontSizeDelta = 4;
            this.tePassword.Properties.Appearance.Options.UseFont = true;
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(214, 26);
            this.tePassword.TabIndex = 4;
            // 
            // buttonStackPanel
            // 
            this.buttonStackPanel.Controls.Add(this.btnLogIn);
            this.buttonStackPanel.Location = new System.Drawing.Point(73, 242);
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
            this.btnLogIn.Size = new System.Drawing.Size(214, 26);
            this.buttonStackPanel.SetStretched(this.btnLogIn, true);
            this.btnLogIn.TabIndex = 1;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // fLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(361, 337);
            this.Controls.Add(this.stackPanel);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel)).EndInit();
            this.stackPanel.ResumeLayout(false);
            this.stackPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStackPanel)).EndInit();
            this.buttonStackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.Utils.Layout.StackPanel stackPanel;
        private DevExpress.XtraEditors.LabelControl labelCaption;
        private DevExpress.XtraEditors.LabelControl labelLogin;
        private DevExpress.XtraEditors.TextEdit teLogin;
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.Utils.Layout.StackPanel buttonStackPanel;
        private DevExpress.XtraEditors.SimpleButton btnLogIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
    }
}