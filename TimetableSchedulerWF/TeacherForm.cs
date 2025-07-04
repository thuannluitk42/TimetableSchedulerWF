using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetableSchedulerWF.Models;

namespace TimetableSchedulerWF
{
    public partial class TeacherForm : MetroForm
    {
        private readonly List<Teacher> _teachers = new List<Teacher>();

        public TeacherForm()
        {
            InitializeComponent();
            RefreshList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtTeacherName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng nhập tên giáo viên.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _teachers.Add(new Teacher { Name = name });
            txtTeacherName.Clear();
            RefreshList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTeachers.SelectedItem is Teacher selected)
            {
                var newName = txtTeacherName.Text.Trim();
                if (string.IsNullOrWhiteSpace(newName))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Vui lòng nhập tên giáo viên.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                selected.Name = newName;
                RefreshList();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng chọn giáo viên để cập nhật.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTeachers.SelectedItem is Teacher selected)
            {
                _teachers.Remove(selected);
                txtTeacherName.Clear();
                RefreshList();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng chọn giáo viên để ẩn.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTeachers.SelectedItem is Teacher selected)
            {
                txtTeacherName.Text = selected.Name;
            }
        }

        private void RefreshList()
        {
            lstTeachers.DataSource = null;
            lstTeachers.DataSource = _teachers;
            lstTeachers.DisplayMember = "Name";
        }
    }
}
