using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TimetableSchedulerWF.Models;

namespace TimetableSchedulerWF
{
    public partial class ClassForm : MetroForm
    {
        private List<Class> Classes = new List<Class>();

        public ClassForm()
        {
            InitializeComponent();
            RefreshList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClassName.Text)) return;

            Classes.Add(new Class { Name = txtClassName.Text.Trim() });
            txtClassName.Clear();
            RefreshList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstClasses.SelectedItem is Class selected)
            {
                selected.Name = txtClassName.Text.Trim();
                RefreshList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstClasses.SelectedItem is Class selected)
            {
                Classes.Remove(selected);
                txtClassName.Clear();
                RefreshList();
            }
        }

        private void lstClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClasses.SelectedItem is Class selected)
                txtClassName.Text = selected.Name;
        }

        private void RefreshList()
        {
            lstClasses.DataSource = null;
            lstClasses.DataSource = Classes;
            lstClasses.DisplayMember = "Name";
        }
    }
}