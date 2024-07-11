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
    public partial class Form1 : Form
    {
        public static Form1 f1;
        public static SqlConnection connection =new SqlConnection(@"Server=LAPTOP-QL8KFE17\SQL;Database=Students;User Id=sa;Password=Qazqaz123.");
        public static SqlDataAdapter adapter;
        public static DataTable dt;
        public static DataGridView datagrid;
        public Form1()
        {
            InitializeComponent();
            datagrid = dataGridView1;
            adapter = new SqlDataAdapter("select Id,CourseName,Duration_months,Price,StartDate,StudentCount from Course",connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
            SqlCommand cmd = new SqlCommand();
             dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource=dt;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

            DataTable dt2 = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("select * from Course",Form1.connection);
            ad.Fill(dt2);
            foreach (DataRow row in dt2.Rows)
            {
                if (Convert.ToInt32(row["StudentCount"].ToString()) >= 3) MessageBox.Show($"You should start {row["CourseName"]}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            adapter.Update(dt);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0) 
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            else 
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void showStudents_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowDialog();
        }

        private void startCourse_Click(object sender, EventArgs e)
        {
            StartCourse sc = new StartCourse();
            sc.ShowDialog();
        }

        private void buttonStartCourse_Click(object sender, EventArgs e)
        {
            CreateCourse cc = new CreateCourse();
            cc.ShowDialog();
        }

        private void buttonUpdateCourse_Click(object sender, EventArgs e)
        {
            int row=Form1.datagrid.CurrentCell.RowIndex;
            string query = $"update Course set ModificationTime=getdate() where CourseName='{Form1.datagrid.Rows[row].Cells[1].Value}'";
            SqlCommand cmd2 = new SqlCommand(query,Form1.connection);
            Form1.connection.Open();
            cmd2.ExecuteNonQuery();
            Form1.connection.Close();
            adapter = new SqlDataAdapter("select Id,CourseName,Duration_months,Price,StartDate from Course", connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
            SqlCommand cmd = new SqlCommand();
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            Form1.adapter.Update(dt);

        }

        private void buttonDeleteCourse_Click(object sender, EventArgs e)
        {
            int row = Form1.datagrid.CurrentCell.RowIndex;
            string query2 = $"delete from Course where CourseName='{Form1.datagrid.Rows[row].Cells[1].Value.ToString()}'";
            SqlCommand cmd3 = new SqlCommand(query2, Form1.connection);
            Form1.connection.Open();
            cmd3.ExecuteNonQuery();
            Form1.connection.Close();
            adapter = new SqlDataAdapter("select Id,CourseName,Duration_months,Price,StartDate from Course", connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
            SqlCommand cmd = new SqlCommand();
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            Form1.adapter.Update(dt);
        }
    }
}
