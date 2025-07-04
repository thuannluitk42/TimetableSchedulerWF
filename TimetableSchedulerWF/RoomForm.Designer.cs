namespace TimetableSchedulerWF
{
    partial class RoomForm
    {
        private System.ComponentModel.IContainer components = null;

        private MetroFramework.Controls.MetroLabel lblTitle;
        private MetroFramework.Controls.MetroLabel lblRoomName;
        private MetroFramework.Controls.MetroTextBox txtRoomName;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.ListBox lstRooms;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.lblRoomName = new MetroFramework.Controls.MetroLabel();
            this.txtRoomName = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(320, 30);
            this.lblTitle.Text = "Quản lý Phòng học";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(30, 80);
            this.lblRoomName.Text = "Tên phòng học:";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(150, 80);
            this.txtRoomName.Size = new System.Drawing.Size(500, 23);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(150, 130);
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(290, 130);
            this.btnEdit.Size = new System.Drawing.Size(120, 35);
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(430, 130);
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstRooms
            // 
            this.lstRooms.Location = new System.Drawing.Point(30, 190);
            this.lstRooms.Size = new System.Drawing.Size(700, 200);
            this.lstRooms.SelectedIndexChanged += new System.EventHandler(this.lstRooms_SelectedIndexChanged);
            // 
            // RoomForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstRooms);
            this.Text = "Quản lý Phòng học";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}