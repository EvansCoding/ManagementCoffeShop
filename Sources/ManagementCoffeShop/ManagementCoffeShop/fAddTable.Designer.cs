namespace ManagementCoffeShop
{
    partial class fAddTable
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
            this.labelLogin = new DevExpress.XtraEditors.LabelControl();
            this.tbNameTable = new DevExpress.XtraEditors.TextEdit();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.cbbArea = new DevExpress.XtraEditors.ComboBoxEdit();
            this.buttonStackPanel = new DevExpress.Utils.Layout.StackPanel();
            this.btnLogIn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel2 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel)).BeginInit();
            this.stackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNameTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStackPanel)).BeginInit();
            this.buttonStackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Colorful";
            // 
            // stackPanel
            // 
            this.stackPanel.Appearance.BackColor = System.Drawing.Color.White;
            this.stackPanel.Appearance.Options.UseBackColor = true;
            this.stackPanel.Controls.Add(this.panel1);
            this.stackPanel.Controls.Add(this.labelLogin);
            this.stackPanel.Controls.Add(this.tbNameTable);
            this.stackPanel.Controls.Add(this.labelPassword);
            this.stackPanel.Controls.Add(this.cbbArea);
            this.stackPanel.Controls.Add(this.buttonStackPanel);
            this.stackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel.Location = new System.Drawing.Point(0, 0);
            this.stackPanel.Name = "stackPanel";
            this.stackPanel.Size = new System.Drawing.Size(298, 226);
            this.stackPanel.TabIndex = 2;
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
            this.labelLogin.Text = "Tên Bàn";
            // 
            // tbNameTable
            // 
            this.tbNameTable.Location = new System.Drawing.Point(42, 54);
            this.tbNameTable.Name = "tbNameTable";
            this.tbNameTable.Properties.Appearance.FontSizeDelta = 4;
            this.tbNameTable.Properties.Appearance.Options.UseFont = true;
            this.tbNameTable.Size = new System.Drawing.Size(214, 26);
            this.tbNameTable.TabIndex = 1;
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
            this.labelPassword.Text = "Khu Vực";
            // 
            // cbbArea
            // 
            this.cbbArea.Location = new System.Drawing.Point(42, 110);
            this.cbbArea.Name = "cbbArea";
            this.cbbArea.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbArea.Properties.Appearance.Options.UseFont = true;
            this.cbbArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbArea.Size = new System.Drawing.Size(214, 26);
            this.cbbArea.TabIndex = 2;
            // 
            // buttonStackPanel
            // 
            this.buttonStackPanel.Controls.Add(this.btnLogIn);
            this.buttonStackPanel.Controls.Add(this.simpleButton1);
            this.buttonStackPanel.Location = new System.Drawing.Point(42, 159);
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
            this.btnLogIn.TabIndex = 3;
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
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // fAddTable
            // 
            this.AcceptButton = this.btnLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 226);
            this.Controls.Add(this.stackPanel);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddTable";
            this.Load += new System.EventHandler(this.fAddTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel)).EndInit();
            this.stackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbNameTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStackPanel)).EndInit();
            this.buttonStackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.Utils.Layout.StackPanel stackPanel;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelLogin;
        private DevExpress.XtraEditors.TextEdit tbNameTable;
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.XtraEditors.ComboBoxEdit cbbArea;
        private DevExpress.Utils.Layout.StackPanel buttonStackPanel;
        private DevExpress.XtraEditors.SimpleButton btnLogIn;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel2;
    }
}