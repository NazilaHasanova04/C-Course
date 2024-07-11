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
    public partial class CreateTeacher : Form
    {
        public CreateTeacher()
        {
            InitializeComponent();
        }

        private void buttonSubmitTeacher_Click(object sender, EventArgs e)
        {
            string query = $"insert into Teacher(Name,Surname,BirthDate,Profession) values(@name,@surname,@date,@prof)";
            SqlCommand cmd = new SqlCommand(query, Form1.connection);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@surname", textBox2.Text);
            cmd.Parameters.AddWithValue("@date", maskedTextBox2.Text);
            cmd.Parameters.AddWithValue("@prof", textBox3.Text);

            Form1.connection.Open();
            cmd.ExecuteNonQuery();
            Form1.connection.Close();

            SqlDataAdapter ad = new SqlDataAdapter("select * from Teacher", Form1.connection);
            DataTable table2 = new DataTable();
            ad.Fill(table2);
            Main.dgvt.DataSource = table2;
            Main.dgvt.EnableHeadersVisualStyles = false;
            Main.dgvt.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            Main.dgvt.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

           ad.Update(table2);
            Close();
        }
    }
}
