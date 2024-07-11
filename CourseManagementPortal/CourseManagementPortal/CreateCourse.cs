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
    public partial class CreateCourse : Form
    {
        public CreateCourse()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
          
            string query = $"insert into Course(CourseName,Duration_months,Price,CreationTime,ModificationTime,StudentCount,StartDate) values(@coursename,@duration,@price,getdate(),null,'',@start)";
            SqlCommand cmd = new SqlCommand(query,Form1.connection);
            cmd.Parameters.AddWithValue("@coursename",textBox1.Text);
            cmd.Parameters.AddWithValue("@duration", textBox2.Text);
            cmd.Parameters.AddWithValue("@price", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@start", maskedTextBox2.Text);

            Form1.connection.Open();
            cmd.ExecuteNonQuery();
            Form1.connection.Close();

            Form1.adapter = new SqlDataAdapter("select Id,CourseName,Duration_months,Price,StartDate from Course", Form1.connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(Form1.adapter);
            SqlCommand cmd2 = new SqlCommand();
            Form1.dt = new DataTable();
            Form1.adapter.Fill(Form1.dt);
            Form1.datagrid.DataSource = Form1.dt;
            Form1.datagrid.EnableHeadersVisualStyles = false;
            Form1.datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            Form1.datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

            Form1.adapter.Update(Form1.dt);
            Close();
        }
    }
}
