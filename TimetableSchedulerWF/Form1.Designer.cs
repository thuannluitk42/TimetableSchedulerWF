namespace TimetableSchedulerWF
{
    partial class Form1 
    {
        private MetroFramework.Controls.MetroTextBox txtClass;
        private MetroFramework.Controls.MetroTextBox txtRoom;
        private MetroFramework.Controls.MetroComboBox cbDay;
        private MetroFramework.Controls.MetroComboBox cbPeriod;
        private MetroFramework.Controls.MetroComboBox cbTeacher;
        private MetroFramework.Controls.MetroLabel labelClass;
        private MetroFramework.Controls.MetroLabel labelTeacher;
        private MetroFramework.Controls.MetroLabel labelRoom;
        private MetroFramework.Controls.MetroLabel labelDay;
        private MetroFramework.Controls.MetroLabel labelPeriod;
        private MetroFramework.Controls.MetroLabel labelTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnReset;

        private void InitializeComponent()
        {
            this.txtClass = new MetroFramework.Controls.MetroTextBox();
            this.txtRoom = new MetroFramework.Controls.MetroTextBox();
            this.cbTeacher = new MetroFramework.Controls.MetroComboBox();
            this.cbDay = new MetroFramework.Controls.MetroComboBox();
            this.cbPeriod = new MetroFramework.Controls.MetroComboBox();
            this.labelClass = new MetroFramework.Controls.MetroLabel();
            this.labelRoom = new MetroFramework.Controls.MetroLabel();
            this.labelTeacher = new MetroFramework.Controls.MetroLabel();
            this.labelDay = new MetroFramework.Controls.MetroLabel();
            this.labelPeriod = new MetroFramework.Controls.MetroLabel();
            this.labelTitle = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClass
            // 
            // 
            // 
            // 
            this.txtClass.CustomButton.Image = null;
            this.txtClass.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.txtClass.CustomButton.Name = "";
            this.txtClass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtClass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClass.CustomButton.TabIndex = 1;
            this.txtClass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClass.CustomButton.UseSelectable = true;
            this.txtClass.CustomButton.Visible = false;
            this.txtClass.Lines = new string[0];
            this.txtClass.Location = new System.Drawing.Point(100, 80);
            this.txtClass.MaxLength = 32767;
            this.txtClass.Name = "txtClass";
            this.txtClass.PasswordChar = '\0';
            this.txtClass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClass.SelectedText = "";
            this.txtClass.SelectionLength = 0;
            this.txtClass.SelectionStart = 0;
            this.txtClass.ShortcutsEnabled = true;
            this.txtClass.Size = new System.Drawing.Size(250, 30);
            this.txtClass.TabIndex = 6;
            this.txtClass.UseSelectable = true;
            this.txtClass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRoom
            // 
            // 
            // 
            // 
            this.txtRoom.CustomButton.Image = null;
            this.txtRoom.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.txtRoom.CustomButton.Name = "";
            this.txtRoom.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtRoom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRoom.CustomButton.TabIndex = 1;
            this.txtRoom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRoom.CustomButton.UseSelectable = true;
            this.txtRoom.CustomButton.Visible = false;
            this.txtRoom.Lines = new string[0];
            this.txtRoom.Location = new System.Drawing.Point(100, 130);
            this.txtRoom.MaxLength = 32767;
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.PasswordChar = '\0';
            this.txtRoom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRoom.SelectedText = "";
            this.txtRoom.SelectionLength = 0;
            this.txtRoom.SelectionStart = 0;
            this.txtRoom.ShortcutsEnabled = true;
            this.txtRoom.Size = new System.Drawing.Size(250, 30);
            this.txtRoom.TabIndex = 7;
            this.txtRoom.UseSelectable = true;
            this.txtRoom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRoom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbTeacher
            // 
            this.cbTeacher.ItemHeight = 24;
            this.cbTeacher.Location = new System.Drawing.Point(701, 80);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(250, 30);
            this.cbTeacher.TabIndex = 8;
            this.cbTeacher.UseSelectable = true;
            // 
            // cbDay
            // 
            this.cbDay.ItemHeight = 24;
            this.cbDay.Location = new System.Drawing.Point(701, 130);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(250, 30);
            this.cbDay.TabIndex = 9;
            this.cbDay.UseSelectable = true;
            // 
            // cbPeriod
            // 
            this.cbPeriod.ItemHeight = 24;
            this.cbPeriod.Location = new System.Drawing.Point(701, 180);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(250, 30);
            this.cbPeriod.TabIndex = 10;
            this.cbPeriod.UseSelectable = true;
            // 
            // labelClass
            // 
            this.labelClass.Location = new System.Drawing.Point(30, 80);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(64, 23);
            this.labelClass.TabIndex = 1;
            this.labelClass.Text = "Lớp:";
            // 
            // labelRoom
            // 
            this.labelRoom.Location = new System.Drawing.Point(30, 130);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(64, 23);
            this.labelRoom.TabIndex = 2;
            this.labelRoom.Text = "Phòng:";
            // 
            // labelTeacher
            // 
            this.labelTeacher.Location = new System.Drawing.Point(606, 80);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(74, 23);
            this.labelTeacher.TabIndex = 3;
            this.labelTeacher.Text = "Giáo viên:";
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(606, 130);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(74, 23);
            this.labelDay.TabIndex = 4;
            this.labelDay.Text = "Thứ:";
            // 
            // labelPeriod
            // 
            this.labelPeriod.Location = new System.Drawing.Point(606, 180);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(74, 23);
            this.labelPeriod.TabIndex = 5;
            this.labelPeriod.Text = "Tiết:";
            // 
            // labelTitle
            // 
            this.labelTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelTitle.Location = new System.Drawing.Point(342, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(400, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HỆ THỐNG SẮP XẾP LỊCH TỰ ĐỘNG";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(340, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(220, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(520, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(640, 230);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 35);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Tải";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.Location = new System.Drawing.Point(30, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(921, 250);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Lớp";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Giáo viên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Phòng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Thứ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tiết";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(100, 280);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Nhập từ khoá...";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(250, 30);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Nhập từ khoá...";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(370, 280);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(460, 280);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 30);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Hiện tất cả";
            this.btnReset.UseSelectable = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(987, 600);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.cbTeacher);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

