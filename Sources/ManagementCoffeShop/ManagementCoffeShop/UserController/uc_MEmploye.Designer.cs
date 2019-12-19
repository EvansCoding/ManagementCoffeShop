namespace ManagementCoffeShop.UserController
{
    partial class uc_MEmploye
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.birthDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dayAtWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusOfWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameOffice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(165, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 60);
            this.panel5.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSave.BackgroundImage = global::ManagementCoffeShop.Properties.Resources.save_64px;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(176, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 60);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1169, 660);
            this.panel2.TabIndex = 11;
            // 
            // gridControl1
            // 
            this.gridControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(0, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1169, 603);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.userName,
            this.password,
            this.fullName,
            this.sex,
            this.birthDay,
            this.address,
            this.phoneNumber,
            this.email,
            this.dayAtWork,
            this.statusOfWork,
            this.nameOffice});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 50;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.Id.AppearanceCell.Options.UseFont = true;
            this.Id.AppearanceCell.Options.UseTextOptions = true;
            this.Id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Id.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.Id.AppearanceHeader.Options.UseFont = true;
            this.Id.AppearanceHeader.Options.UseTextOptions = true;
            this.Id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Id.Caption = "Mã NV";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            this.Id.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 35;
            // 
            // userName
            // 
            this.userName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.userName.AppearanceCell.Options.UseFont = true;
            this.userName.AppearanceCell.Options.UseTextOptions = true;
            this.userName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.userName.AppearanceHeader.Options.UseTextOptions = true;
            this.userName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.userName.Caption = "Tên Đăng Nhập";
            this.userName.FieldName = "userName";
            this.userName.Name = "userName";
            this.userName.OptionsColumn.AllowEdit = false;
            this.userName.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.userName.Visible = true;
            this.userName.VisibleIndex = 1;
            this.userName.Width = 80;
            // 
            // password
            // 
            this.password.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.password.AppearanceCell.Options.UseFont = true;
            this.password.AppearanceCell.Options.UseTextOptions = true;
            this.password.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.password.AppearanceHeader.Options.UseTextOptions = true;
            this.password.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.password.Caption = "Mật Khẩu";
            this.password.FieldName = "password";
            this.password.Name = "password";
            this.password.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.password.Visible = true;
            this.password.VisibleIndex = 2;
            this.password.Width = 65;
            // 
            // fullName
            // 
            this.fullName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.fullName.AppearanceCell.Options.UseFont = true;
            this.fullName.AppearanceCell.Options.UseTextOptions = true;
            this.fullName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fullName.AppearanceHeader.Options.UseTextOptions = true;
            this.fullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fullName.Caption = "Họ & Tên";
            this.fullName.FieldName = "fullName";
            this.fullName.Name = "fullName";
            this.fullName.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.fullName.Visible = true;
            this.fullName.VisibleIndex = 3;
            this.fullName.Width = 118;
            // 
            // sex
            // 
            this.sex.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex.AppearanceCell.Options.UseFont = true;
            this.sex.AppearanceCell.Options.UseTextOptions = true;
            this.sex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sex.Caption = "Nam";
            this.sex.FieldName = "sex";
            this.sex.Name = "sex";
            this.sex.Visible = true;
            this.sex.VisibleIndex = 4;
            this.sex.Width = 42;
            // 
            // birthDay
            // 
            this.birthDay.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDay.AppearanceCell.Options.UseFont = true;
            this.birthDay.AppearanceCell.Options.UseTextOptions = true;
            this.birthDay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.birthDay.Caption = "NgSinh";
            this.birthDay.FieldName = "birthDay";
            this.birthDay.Name = "birthDay";
            this.birthDay.Visible = true;
            this.birthDay.VisibleIndex = 5;
            this.birthDay.Width = 50;
            // 
            // address
            // 
            this.address.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.AppearanceCell.Options.UseFont = true;
            this.address.AppearanceCell.Options.UseTextOptions = true;
            this.address.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.address.Caption = "Địa Chỉ";
            this.address.FieldName = "address";
            this.address.Name = "address";
            this.address.Visible = true;
            this.address.VisibleIndex = 6;
            this.address.Width = 58;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.AppearanceCell.Options.UseFont = true;
            this.phoneNumber.AppearanceCell.Options.UseTextOptions = true;
            this.phoneNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.phoneNumber.Caption = "SĐT";
            this.phoneNumber.FieldName = "phoneNumber";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Visible = true;
            this.phoneNumber.VisibleIndex = 7;
            this.phoneNumber.Width = 58;
            // 
            // email
            // 
            this.email.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.AppearanceCell.Options.UseFont = true;
            this.email.AppearanceCell.Options.UseTextOptions = true;
            this.email.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.email.Caption = "Email";
            this.email.FieldName = "email";
            this.email.Name = "email";
            this.email.Visible = true;
            this.email.VisibleIndex = 8;
            this.email.Width = 79;
            // 
            // dayAtWork
            // 
            this.dayAtWork.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayAtWork.AppearanceCell.Options.UseFont = true;
            this.dayAtWork.AppearanceCell.Options.UseTextOptions = true;
            this.dayAtWork.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dayAtWork.Caption = "NgV Làm";
            this.dayAtWork.FieldName = "dayAtWork";
            this.dayAtWork.Name = "dayAtWork";
            this.dayAtWork.OptionsColumn.AllowEdit = false;
            this.dayAtWork.Visible = true;
            this.dayAtWork.VisibleIndex = 9;
            this.dayAtWork.Width = 59;
            // 
            // statusOfWork
            // 
            this.statusOfWork.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusOfWork.AppearanceCell.Options.UseFont = true;
            this.statusOfWork.AppearanceCell.Options.UseTextOptions = true;
            this.statusOfWork.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.statusOfWork.Caption = "Trạng Thái";
            this.statusOfWork.FieldName = "statusOfWork";
            this.statusOfWork.Name = "statusOfWork";
            this.statusOfWork.Visible = true;
            this.statusOfWork.VisibleIndex = 10;
            this.statusOfWork.Width = 64;
            // 
            // nameOffice
            // 
            this.nameOffice.AppearanceCell.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOffice.AppearanceCell.Options.UseFont = true;
            this.nameOffice.AppearanceCell.Options.UseTextOptions = true;
            this.nameOffice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameOffice.Caption = "Chức Vụ";
            this.nameOffice.FieldName = "nameOffice";
            this.nameOffice.Name = "nameOffice";
            this.nameOffice.Visible = true;
            this.nameOffice.VisibleIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 57);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::ManagementCoffeShop.Properties.Resources.delete_forever_60px;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(99, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 60);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 660);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1169, 76);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnReport);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Location = new System.Drawing.Point(416, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 60);
            this.panel4.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnAdd.BackgroundImage = global::ManagementCoffeShop.Properties.Resources.file_48px;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(20, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 60);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::ManagementCoffeShop.Properties.Resources.print_64px;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(252, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(60, 60);
            this.btnReport.TabIndex = 3;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // uc_MEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "uc_MEmploye";
            this.Size = new System.Drawing.Size(1169, 736);
            this.Load += new System.EventHandler(this.uc_MEmploye_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn userName;
        private DevExpress.XtraGrid.Columns.GridColumn password;
        private DevExpress.XtraGrid.Columns.GridColumn fullName;
        private DevExpress.XtraGrid.Columns.GridColumn sex;
        private DevExpress.XtraGrid.Columns.GridColumn birthDay;
        private DevExpress.XtraGrid.Columns.GridColumn address;
        private DevExpress.XtraGrid.Columns.GridColumn phoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn email;
        private DevExpress.XtraGrid.Columns.GridColumn dayAtWork;
        private DevExpress.XtraGrid.Columns.GridColumn statusOfWork;
        private DevExpress.XtraGrid.Columns.GridColumn nameOffice;
    }
}
