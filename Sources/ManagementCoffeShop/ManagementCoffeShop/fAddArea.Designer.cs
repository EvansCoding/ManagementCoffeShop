﻿namespace ManagementCoffeShop
{
    partial class fAddArea
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
            this.tbNameTable = new DevExpress.XtraEditors.TextEdit();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.tbNote = new DevExpress.XtraEditors.TextEdit();
            this.buttonStackPanel = new DevExpress.Utils.Layout.StackPanel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel)).BeginInit();
            this.stackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNameTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStackPanel)).BeginInit();
            this.buttonStackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel
            // 
            this.stackPanel.Appearance.BackColor = System.Drawing.Color.White;
            this.stackPanel.Appearance.Options.UseBackColor = true;
            this.stackPanel.Controls.Add(this.panel1);
            this.stackPanel.Controls.Add(this.labelLogin);
            this.stackPanel.Controls.Add(this.tbNameTable);
            this.stackPanel.Controls.Add(this.labelPassword);
            this.stackPanel.Controls.Add(this.tbNote);
            this.stackPanel.Controls.Add(this.buttonStackPanel);
            this.stackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel.Location = new System.Drawing.Point(0, 0);
            this.stackPanel.Name = "stackPanel";
            this.stackPanel.Size = new System.Drawing.Size(298, 224);
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
            this.labelLogin.Text = "Khu Vực";
            // 
            // tbNameTable
            // 
            this.tbNameTable.Location = new System.Drawing.Point(42, 54);
            this.tbNameTable.Name = "tbNameTable";
            this.tbNameTable.Properties.Appearance.FontSizeDelta = 4;
            this.tbNameTable.Properties.Appearance.Options.UseFont = true;
            this.tbNameTable.Size = new System.Drawing.Size(214, 26);
            this.tbNameTable.TabIndex = 2;
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
            this.labelPassword.Text = "Ghi Chú";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(42, 110);
            this.tbNote.Name = "tbNote";
            this.tbNote.Properties.Appearance.FontSizeDelta = 4;
            this.tbNote.Properties.Appearance.Options.UseFont = true;
            this.tbNote.Size = new System.Drawing.Size(214, 26);
            this.tbNote.TabIndex = 9;
            // 
            // buttonStackPanel
            // 
            this.buttonStackPanel.Controls.Add(this.btnAdd);
            this.buttonStackPanel.Controls.Add(this.btnExit);
            this.buttonStackPanel.Location = new System.Drawing.Point(42, 159);
            this.buttonStackPanel.Margin = new System.Windows.Forms.Padding(20);
            this.buttonStackPanel.Name = "buttonStackPanel";
            this.buttonStackPanel.Size = new System.Drawing.Size(214, 40);
            this.buttonStackPanel.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 7);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 26);
            this.buttonStackPanel.SetStretched(this.btnAdd, true);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(107, 7);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 26);
            this.buttonStackPanel.SetStretched(this.btnExit, true);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Colorful";
            // 
            // fAddArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 224);
            this.Controls.Add(this.stackPanel);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddArea";
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel)).EndInit();
            this.stackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbNameTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStackPanel)).EndInit();
            this.buttonStackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.StackPanel stackPanel;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelLogin;
        private DevExpress.XtraEditors.TextEdit tbNameTable;
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.Utils.Layout.StackPanel buttonStackPanel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.TextEdit tbNote;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}