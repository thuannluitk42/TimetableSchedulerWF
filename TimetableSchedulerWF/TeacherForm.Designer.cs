namespace TimetableSchedulerWF
{
    partial class TeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.lblTeacherName = new MetroFramework.Controls.MetroLabel();
            this.txtTeacherName = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.lstTeachers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(300, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 19);
            this.lblTitle.Text = "Quản lý giáo viên";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(30, 80);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(95, 19);
            this.lblTeacherName.Text = "Tên giáo viên:";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(140, 80);
            this.txtTeacherName.Size = new System.Drawing.Size(500, 23);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(140, 130);
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(280, 130);
            this.btnEdit.Size = new System.Drawing.Size(120, 35);
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(420, 130);
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstTeachers
            // 
            this.lstTeachers.Location = new System.Drawing.Point(30, 190);
            this.lstTeachers.Size = new System.Drawing.Size(700, 200);
            this.lstTeachers.SelectedIndexChanged += new System.EventHandler(this.lstTeachers_SelectedIndexChanged);
            //
            // TeacherForm
            //
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstTeachers);
            this.Text = "Quản lý giáo viên";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtTeacherName;
        private MetroFramework.Controls.MetroLabel lblTeacherName;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.ListBox lstTeachers;
        private MetroFramework.Controls.MetroLabel lblTitle;
    }
}
