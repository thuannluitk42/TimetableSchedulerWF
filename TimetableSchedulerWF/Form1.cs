using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TimetableSchedulerWF.Models;

namespace TimetableSchedulerWF
{
    public partial class Form1 : Form
    {
        // Danh sách giáo viên cố định
        private readonly List<Teacher> _teachers = new List<Teacher>
        {
            new Teacher { Name = "Cô. Hân" },
            new Teacher { Name = "Thầy. Dũ" },
            new Teacher { Name = "Cô. Hồng" },
            new Teacher { Name = "Thầy. Long" },
            new Teacher { Name = "Thầy. Sang" }
        };

        // Danh sách lịch hiện tại
        private List<ScheduleEntry> _scheduleEntries = new List<ScheduleEntry>();

        // Kết quả backtracking
        private List<ScheduleEntry> _result = new List<ScheduleEntry>();

        public Form1()
        {
            InitializeComponent();
            InitializeControls();
        }

        /// <summary>
        /// Cài đặt dữ liệu cho ComboBox và Grid khi khởi chạy.
        /// </summary>
        private void InitializeControls()
        {
            cbDay.DataSource = Enum.GetValues(typeof(DayOfWeek));
            cbPeriod.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6 });

            cbTeacher.DataSource = _teachers;
            cbTeacher.DisplayMember = "Name";

            dataGridView1.AutoGenerateColumns = true;
        }

        /// <summary>
        /// Làm mới DataGridView.
        /// </summary>
        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _scheduleEntries.Select(x => new
            {
                Class = x.Class.Name,
                Teacher = x.Teacher.Name,
                Room = x.Room.Name,
                Day = x.Day,
                Period = x.Period
            }).ToList();
        }

        /// <summary>
        /// Thêm lịch học mới.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            var newEntry = new ScheduleEntry
            {
                Class = new Class { Name = txtClass.Text.Trim() },
                Teacher = (Teacher)cbTeacher.SelectedItem,
                Room = new Room { Name = txtRoom.Text.Trim() },
                Day = (DayOfWeek)cbDay.SelectedItem,
                Period = Convert.ToInt32(cbPeriod.SelectedItem)
            };

            if (HasConflict(newEntry, _scheduleEntries))
            {
                MessageBox.Show("Conflict detected! Same slot used by class/teacher/room.");
                return;
            }

            _scheduleEntries.Add(newEntry);
            RefreshGrid();
        }

        /// <summary>
        /// Xoá lịch học đã chọn.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var row = dataGridView1.SelectedRows[0];
            var className = row.Cells["Class"].Value.ToString();
            var teacherName = row.Cells["Teacher"].Value.ToString();
            var roomName = row.Cells["Room"].Value.ToString();
            var day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), row.Cells["Day"].Value.ToString());
            var period = Convert.ToInt32(row.Cells["Period"].Value);

            var entry = _scheduleEntries.FirstOrDefault(x =>
                x.Class.Name == className &&
                x.Teacher.Name == teacherName &&
                x.Room.Name == roomName &&
                x.Day == day &&
                x.Period == period);

            if (entry != null)
            {
                _scheduleEntries.Remove(entry);
                RefreshGrid();
            }
        }

        /// <summary>
        /// Lưu lịch ra file TXT.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var sw = new StreamWriter("schedule.txt"))
            {
                foreach (var entry in _scheduleEntries)
                {
                    sw.WriteLine($"{entry.Class.Name},{entry.Teacher.Name},{entry.Room.Name},{entry.Day},{entry.Period}");
                }
            }

            MessageBox.Show("Saved to schedule.txt");
        }

        /// <summary>
        /// Sinh lịch ngẫu nhiên.
        /// </summary>
        private void btnAutoGenerate_Click(object sender, EventArgs e)
        {
            var classes = new List<Class>
            {
                new Class { Name = "Toán" },
                new Class { Name = "Vật Lý" },
                new Class { Name = "Hoá Học" },
                new Class { Name = "Ngữ Văn" },
                new Class { Name = "Tiếng Anh" }
            };

            var rooms = new List<Room>
            {
                new Room { Name = "PV 101" },
                new Room { Name = "PV 102" },
                new Room { Name = "HD 101" },
                new Room { Name = "HD 102" },
                new Room { Name = "Lab 1" }
            };

            var rand = new Random();
            _scheduleEntries.Clear();

            foreach (var cls in classes)
            {
                var teacher = _teachers[rand.Next(_teachers.Count)];
                var room = rooms[rand.Next(rooms.Count)];
                var day = (DayOfWeek)rand.Next(1, 6);
                var period = rand.Next(1, 7);

                var entry = new ScheduleEntry
                {
                    Class = cls,
                    Teacher = teacher,
                    Room = room,
                    Day = day,
                    Period = period
                };

                if (!HasConflict(entry, _scheduleEntries))
                {
                    _scheduleEntries.Add(entry);
                }
            }

            RefreshGrid();
        }

        /// <summary>
        /// Backtracking sắp xếp tối ưu.
        /// </summary>
        private void btnBacktracking_Click(object sender, EventArgs e)
        {
            var classes = new List<Class>
            {
                new Class { Name = "Math" },
                new Class { Name = "Physics" },
                new Class { Name = "Chemistry" }
            };

            var rooms = new List<Room>
            {
                new Room { Name = "Room 101" },
                new Room { Name = "Room 102" },
                new Room { Name = "Lab 1" }
            };

            var slots = new List<Slot>();
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday) continue;

                for (int p = 1; p <= 5; p++)
                {
                    slots.Add(new Slot { Day = day, Period = p });
                }
            }

            var current = new List<ScheduleEntry>();
            bool success = Backtracking(classes, _teachers, rooms, slots, current, 0);

            if (success)
            {
                _scheduleEntries = _result;
                RefreshGrid();
                MessageBox.Show("Timetable found successfully!");
            }
            else
            {
                MessageBox.Show("No valid timetable found.");
            }
        }

        /// <summary>
        /// Backtracking core.
        /// </summary>
        private bool Backtracking(List<Class> classes, List<Teacher> teachers, List<Room> rooms, List<Slot> slots, List<ScheduleEntry> current, int index)
        {
            if (index >= classes.Count)
            {
                _result = current.ToList();
                return true;
            }

            var cls = classes[index];

            foreach (var teacher in teachers)
            {
                foreach (var room in rooms)
                {
                    foreach (var slot in slots)
                    {
                        var entry = new ScheduleEntry
                        {
                            Class = cls,
                            Teacher = teacher,
                            Room = room,
                            Day = slot.Day,
                            Period = slot.Period
                        };

                        if (HasConflict(entry, current))
                            continue;

                        current.Add(entry);

                        if (Backtracking(classes, teachers, rooms, slots, current, index + 1))
                            return true;

                        current.RemoveAt(current.Count - 1);
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Kiểm tra xung đột slot.
        /// </summary>
        private bool HasConflict(ScheduleEntry newEntry, List<ScheduleEntry> list)
        {
            return list.Any(e =>
                e.Day == newEntry.Day &&
                e.Period == newEntry.Period &&
                (e.Teacher.Name == newEntry.Teacher.Name ||
                 e.Room.Name == newEntry.Room.Name ||
                 e.Class.Name == newEntry.Class.Name));
        }

        /// <summary>
        /// Kiểm tra dữ liệu nhập.
        /// </summary>
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtClass.Text) || string.IsNullOrWhiteSpace(txtRoom.Text) ||
                cbTeacher.SelectedItem == null || cbDay.SelectedItem == null || cbPeriod.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }

            return true;
        }
    }
}
