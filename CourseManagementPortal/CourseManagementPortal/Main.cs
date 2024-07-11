using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementPortal
{
    public partial class Main : Form
    {
        public static DataGridView dgv,dgvt;
        public static DataTable table;
        public static SqlDataAdapter adapter;
        public Main()
        {
            InitializeComponent();
            Form1.adapter = new System.Data.SqlClient.SqlDataAdapter("select * from Student", Form1.connection);
            DataTable table = new DataTable();
            Form1.adapter.Fill(table);
            dataGridViewStudent.DataSource = table;

            SqlDataAdapter ad = new SqlDataAdapter("select * from Teacher",Form1.connection);
            DataTable table2 = new DataTable();
            ad.Fill(table2);
            dataGridViewTeacher.DataSource = table2;
            dgvt = dataGridViewTeacher;
            table = table2;
            SqlDataAdapter add = new SqlDataAdapter("select * from studentsCourses", Form1.connection);
            DataTable table3 = new DataTable();
            add.Fill(table3);
            dataGridViewSC.DataSource = table3;
            adapter = add;

            DataGridViewButtonColumn selectButtonColumn = new DataGridViewButtonColumn();
            selectButtonColumn.Name = "Button";
            selectButtonColumn.Text = "Select";
            selectButtonColumn.UseColumnTextForButtonValue = true;
            int columnIndex = 4;
            if (dataGridViewSC.Columns["select_column"] == null)
            {
                dataGridViewSC.Columns.Insert(columnIndex, selectButtonColumn);
            }
            dataGridViewSC.CellClick += dataGridViewSC_CellContentClick;
           

        }





        private void dataGridViewSC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv = dataGridViewSC;
            if (e.ColumnIndex == dataGridViewSC.Columns["Button"].Index)
            {
                AttendenceAndFeedbacks af = new AttendenceAndFeedbacks();
                af.ShowDialog();
            }
        }

        private void dataGridViewSC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
           Main.adapter.Update(table);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int row =dgvt.CurrentCell.RowIndex;
            string query2 = $"delete from Teacher where Id={dgvt.Rows[row].Cells[0].Value}";
            SqlCommand cmd3 = new SqlCommand(query2, Form1.connection);
            Form1.connection.Open();
            cmd3.ExecuteNonQuery();
            Form1.connection.Close();
            adapter = new SqlDataAdapter("select * from Teacher", Form1.connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
            SqlCommand cmd = new SqlCommand();
            table = new DataTable();
            adapter.Fill(table);
            dgvt.DataSource = table;
            dgvt.EnableHeadersVisualStyles = false;
            dgvt.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvt.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            adapter.Update(table);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTeacher ct = new CreateTeacher();
            ct.ShowDialog();
        }
    }
}
