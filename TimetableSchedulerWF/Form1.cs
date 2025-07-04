using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TimetableSchedulerWF.Models;

namespace TimetableSchedulerWF
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        // Danh sách giáo viên mẫu
        private readonly List<Teacher> _teachers = new List<Teacher>()
        {
            new Teacher { Name = "Cô. Hân" },
            new Teacher { Name = "Thầy. Dũ" },
            new Teacher { Name = "Cô. Hồng" },
            new Teacher { Name = "Thầy. Long" },
            new Teacher { Name = "Thầy. Sang" }
        };

        private List<ScheduleEntry> _scheduleEntries = new List<ScheduleEntry>();
        private List<ScheduleEntry> _result = new List<ScheduleEntry>();

        public Form1()
        {
            InitializeComponent();
            InitializeControls();
        }

        /// <summary>
        /// Cài đặt ComboBox và TextBox ban đầu.
        /// </summary>
        private void InitializeControls()
        {
            cbDay.Items.Add("-- Chọn thứ --");
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
                cbDay.Items.Add(day);
            cbDay.SelectedIndex = 0;

            cbPeriod.Items.Add("-- Chọn tiết --");
            for (int i = 1; i <= 6; i++)
                cbPeriod.Items.Add(i);
            cbPeriod.SelectedIndex = 0;

            cbTeacher.Items.Add("-- Chọn giáo viên --");
            foreach (var t in _teachers)
                cbTeacher.Items.Add(t);
            cbTeacher.DisplayMember = "Name";
            cbTeacher.SelectedIndex = 0;

            txtClass.PromptText = "Nhập tên lớp...";
            txtRoom.PromptText = "Nhập tên phòng...";

            dataGridView1.AutoGenerateColumns = true;
        }

        /// <summary>
        /// Làm mới DataGridView.
        /// </summary>
        private void RefreshGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var entry in _scheduleEntries)
            {
                dataGridView1.Rows.Add(
                    entry.Class.Name,
                    entry.Teacher.Name,
                    entry.Room.Name,
                    entry.Day,
                    entry.Period
                );
            }
        }

        /// <summary> Thêm lịch </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var newEntry = new ScheduleEntry
            {
                Class = new Class { Name = txtClass.Text.Trim() },
                Teacher = cbTeacher.SelectedItem as Teacher,
                Room = new Room { Name = txtRoom.Text.Trim() },
                Day = (DayOfWeek)cbDay.SelectedItem,
                Period = Convert.ToInt32(cbPeriod.SelectedItem)
            };

            if (HasConflictAdvanced(newEntry))
            {
                MetroFramework.MetroMessageBox.Show(this, "Xung đột lịch!", "Xung đột",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _scheduleEntries.Add(newEntry);
            RefreshGrid();
        }

        /// <summary> Xoá lịch </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow?.Index ?? -1;
            if (index < 0 || index >= _scheduleEntries.Count)
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn lịch để xoá!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MetroFramework.MetroMessageBox.Show(this, "Xác nhận xoá lịch này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _scheduleEntries.RemoveAt(index);
                RefreshGrid();
            }
        }

        /// <summary> Cập nhật lịch </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow?.Index ?? -1;

            if (index < 0 || index >= _scheduleEntries.Count)
            {
                MetroFramework.MetroMessageBox.Show(this, "Hãy chọn lịch để cập nhật!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInput()) return;

            var updatedEntry = new ScheduleEntry
            {
                Class = new Class { Name = txtClass.Text.Trim() },
                Teacher = cbTeacher.SelectedItem as Teacher,
                Room = new Room { Name = txtRoom.Text.Trim() },
                Day = (DayOfWeek)cbDay.SelectedItem,
                Period = Convert.ToInt32(cbPeriod.SelectedItem)
            };

            // Tạm loại bỏ entry hiện tại để so xung đột
            var tempList = _scheduleEntries.Where((_, i) => i != index).ToList();

            if (HasConflictAdvanced(updatedEntry, tempList))
            {
                MetroFramework.MetroMessageBox.Show(this, "Xung đột lịch!", "Xung đột",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _scheduleEntries[index] = updatedEntry;

            RefreshGrid();
            ClearInput();
            MetroFramework.MetroMessageBox.Show(this, "Đã cập nhật!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearInput()
        {
            txtClass.Clear();
            txtRoom.Clear();
            cbTeacher.SelectedIndex = -1;
            cbDay.SelectedIndex = -1;
            cbPeriod.SelectedIndex = -1;
        }

        /// <summary> Lưu JSON </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var json = System.Text.Json.JsonSerializer.Serialize(_scheduleEntries);
                string path = Path.GetFullPath("schedule.json");
                File.WriteAllText(path, json);
                MetroFramework.MetroMessageBox.Show(this, "Đã lưu file `schedule.json`!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Lỗi khi lưu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary> Load JSON </summary>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // link to file schedule.json: TimetableSchedulerWF\bin\Debug\net472\schedule.json
                string path = Path.GetFullPath("schedule.json");
                //Console.WriteLine(path);
                if (!File.Exists(path))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Không tìm thấy file.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var json = File.ReadAllText(path);
                _scheduleEntries = System.Text.Json.JsonSerializer.Deserialize<List<ScheduleEntry>>(json) ?? new List<ScheduleEntry>();
                RefreshGrid();
                MetroFramework.MetroMessageBox.Show(this, "Đã tải lại lịch!", "Hoàn tất",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Lỗi khi tải: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary> Sinh ngẫu nhiên lịch </summary>
        private void btnAutoGenerate_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            _scheduleEntries.Clear();

            var classes = new[] { "Toán", "Lý", "Hoá", "Văn", "Anh" }.Select(name => new Class { Name = name }).ToList();
            var rooms = new[] { "101", "102", "103" }.Select(name => new Room { Name = name }).ToList();

            foreach (var cls in classes)
            {
                var entry = new ScheduleEntry
                {
                    Class = cls,
                    Teacher = _teachers[rand.Next(_teachers.Count)],
                    Room = rooms[rand.Next(rooms.Count)],
                    Day = (DayOfWeek)rand.Next(1, 6),
                    Period = rand.Next(1, 7)
                };

                if (!HasConflict(entry, _scheduleEntries))
                    _scheduleEntries.Add(entry);
            }

            RefreshGrid();
        }

        /// <summary> Backtracking tối ưu </summary>
        private void btnBacktracking_Click(object sender, EventArgs e)
        {
            var classes = new[] { "Math", "Physics", "Chemistry" }.Select(n => new Class { Name = n }).ToList();
            var rooms = new[] { "Room 101", "Room 102", "Lab 1" }.Select(n => new Room { Name = n }).ToList();
            var slots = new List<Slot>();

            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
                if (day >= DayOfWeek.Monday && day <= DayOfWeek.Friday)
                    for (int p = 1; p <= 5; p++) slots.Add(new Slot { Day = day, Period = p });

            bool success = Backtracking(classes, _teachers, rooms, slots, new List<ScheduleEntry>(), 0);

            MetroFramework.MetroMessageBox.Show(this,
                success ? "Đã tìm thấy lịch tối ưu!" : "Không tìm thấy lịch phù hợp.",
                "Kết quả", MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (success)
            {
                _scheduleEntries = _result;
                RefreshGrid();
            }
        }

        private bool Backtracking(List<Class> classes, List<Teacher> teachers, List<Room> rooms, List<Slot> slots, List<ScheduleEntry> current, int index)
        {
            if (index >= classes.Count)
            {
                _result = current.ToList();
                return true;
            }

            var cls = classes[index];
            foreach (var teacher in teachers)
                foreach (var room in rooms)
                    foreach (var slot in slots)
                    {
                        var entry = new ScheduleEntry { Class = cls, Teacher = teacher, Room = room, Day = slot.Day, Period = slot.Period };

                        if (HasConflict(entry, current)) continue;

                        current.Add(entry);
                        if (Backtracking(classes, teachers, rooms, slots, current, index + 1)) return true;
                        current.RemoveAt(current.Count - 1);
                    }

            return false;
        }

        /// <summary> Kiểm tra xung đột slot </summary>
        private bool HasConflict(ScheduleEntry newEntry, List<ScheduleEntry> list) =>
            list.Any(e => e.Day == newEntry.Day && e.Period == newEntry.Period &&
                         (e.Teacher.Name == newEntry.Teacher.Name || e.Room.Name == newEntry.Room.Name || e.Class.Name == newEntry.Class.Name));

        private bool HasConflictAdvanced(ScheduleEntry newEntry, List<ScheduleEntry> list = null) =>
            (list ?? _scheduleEntries).Any(e => e.Day == newEntry.Day && e.Period == newEntry.Period &&
                                                (e.Teacher.Name.Equals(newEntry.Teacher.Name, StringComparison.OrdinalIgnoreCase) ||
                                                 e.Room.Name.Equals(newEntry.Room.Name, StringComparison.OrdinalIgnoreCase) ||
                                                 e.Class.Name.Equals(newEntry.Class.Name, StringComparison.OrdinalIgnoreCase)));

        /// <summary> Validate dữ liệu </summary>
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtClass.Text) || string.IsNullOrWhiteSpace(txtRoom.Text)
                || cbTeacher.SelectedIndex <= 0 || cbDay.SelectedIndex <= 0 || cbPeriod.SelectedIndex <= 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            var filtered = _scheduleEntries.Where(entry =>
                entry.Class.Name.ToLower().Contains(keyword) ||
                entry.Teacher.Name.ToLower().Contains(keyword) ||
                entry.Room.Name.ToLower().Contains(keyword) ||
                entry.Day.ToString().ToLower().Contains(keyword) ||
                entry.Period.ToString().Contains(keyword)
            ).ToList();

            dataGridView1.Rows.Clear();
            foreach (var entry in filtered)
            {
                dataGridView1.Rows.Add(
                    entry.Class.Name,
                    entry.Teacher.Name,
                    entry.Room.Name,
                    entry.Day,
                    entry.Period
                );
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            RefreshGrid();
        }

    }
}
