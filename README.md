# 📅 Timetable Scheduler WF

_A modern Windows Forms application for automatic timetable management_

---

## ✨ Overview

**Timetable Scheduler WF** is a simple yet powerful Windows Forms (.NET) desktop application designed to help schools, colleges, or training centers easily manage and schedule classes.

This app provides a user-friendly interface using **MetroFramework** for a clean, modern UI, and saves all schedule data in a local `schedule.json` file.

---

## ✅ Features

- **Add New Schedules** — Create new timetable entries for classes, teachers, rooms, days, and periods.
- **Update / Edit Entries** — Modify any existing schedule entry directly.
- **Delete Entries** — Remove outdated or incorrect schedules safely with confirmation.
- **Advanced Conflict Checker** — Prevent scheduling conflicts such as double-booked rooms or teachers.
- **Search & Filter** — Quickly search for classes, teachers, or rooms with instant results.
- **Save & Load** — Persist schedules locally in a JSON file. Easily reload your saved timetables.

---

## 🧩 Tech Stack

- **C# (.NET Framework)** — Desktop development.
- **Windows Forms (WinForms)** — Simple, classic desktop UI technology.
- **MetroFramework** — For a modern, Metro-style UI.
- **System.Text.Json** or **Newtonsoft.Json** — JSON serialization and deserialization.

---

## 📂 Project Structure

```plaintext
TimetableSchedulerWF/
 ├── TimetableSchedulerWF/
 │   ├── Form1.cs            # Main form logic
 │   ├── Form1.Designer.cs   # UI designer code
 │   ├── Models/
 │   │   ├── Class.cs
 │   │   ├── Teacher.cs
 │   │   ├── Room.cs
 │   │   ├── ScheduleEntry.cs
 │   ├── schedule.json       # Auto-generated data file
