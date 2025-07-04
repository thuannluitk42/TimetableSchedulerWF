using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TimetableSchedulerWF.Models;

namespace TimetableSchedulerWF
{
    public partial class RoomForm : MetroForm
    {
        private List<Room> Rooms = new List<Room>();

        public RoomForm()
        {
            InitializeComponent();
            RefreshList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text)) return;

            Rooms.Add(new Room { Name = txtRoomName.Text.Trim() });
            txtRoomName.Clear();
            RefreshList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstRooms.SelectedItem is Room selected)
            {
                selected.Name = txtRoomName.Text.Trim();
                RefreshList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstRooms.SelectedItem is Room selected)
            {
                Rooms.Remove(selected);
                txtRoomName.Clear();
                RefreshList();
            }
        }

        private void lstRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRooms.SelectedItem is Room selected)
                txtRoomName.Text = selected.Name;
        }

        private void RefreshList()
        {
            lstRooms.DataSource = null;
            lstRooms.DataSource = Rooms;
            lstRooms.DisplayMember = "Name";
        }
    }
}
