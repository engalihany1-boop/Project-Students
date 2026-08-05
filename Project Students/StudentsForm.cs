using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace Project_Students
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("ID","");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Dept", "Dept");
            dataGridView1.Columns.Add("Year", "Year");
            dataGridView1.Columns.Add("GPA", "GPA");
            dataGridView1.Columns.Add("Status", "Status");
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cboDept.Items.Add("CS");
            cboDept.Items.Add("IT");
            cboDept.Items.Add("IS");
            cboDept.Items.Add("AI");
            cboDept.SelectedIndex = 0;
            LoadGrid();
        }

        private void LoadGrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < MainForm.SCount; i++)
            {
                var s = MainForm.Students[i];
                dataGridView1.Rows.Add(
                    s.GetID(), s.GetName(),
                    s.GetDept(), s.GetYear(),
                    s.GetGPA(), s.GetStatus());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtID.Text == "")
                    throw new Exception("Name and ID are required!");

                for (int i = 0; i < MainForm.SCount; i++)
                    if (MainForm.Students[i].GetID() == txtID.Text)
                        throw new Exception("Student ID already exists!");

                Department dept = (Department)cboDept.SelectedIndex;
                int year = int.Parse(txtYear.Text);

                var student = new Student(
                    txtName.Text, txtID.Text,
                    txtEmail.Text, txtPhone.Text,
                    year, dept);

                MainForm.Students[MainForm.SCount++] = student;
                FileManager.SaveStudents();
                LoadGrid();
                ClearFields();
                MessageBox.Show("Student added!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            for (int i = 0; i < MainForm.SCount; i++)
            {
                if (MainForm.Students[i].GetID() == id)
                {
                    for (int j = i; j < MainForm.SCount - 1; j++)
                        MainForm.Students[j] = MainForm.Students[j + 1];
                    MainForm.SCount--;
                    break;
                }
            }
            FileManager.SaveStudents();
            LoadGrid();
        }

        private void txtSearch_TextChanged(object s, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string q = txtSearch.Text.ToLower();
            for (int i = 0; i < MainForm.SCount; i++)
            {
                var st = MainForm.Students[i];
                if (st.GetName().ToLower().Contains(q) ||
                    st.GetID().Contains(q))
                    dataGridView1.Rows.Add(
                        st.GetID(), st.GetName(),
                        st.GetDept(), st.GetYear(),
                        st.GetGPA(), st.GetStatus());
            }
        }

        private void ClearFields()
        {
            txtName.Clear(); txtID.Clear();
            txtEmail.Clear(); txtPhone.Clear(); txtYear.Clear();
            cboDept.SelectedIndex = 0;
        }
    }
}