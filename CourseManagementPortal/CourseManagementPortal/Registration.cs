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
    public partial class Registration : Form
    {
        public static Registration formr;
        public Registration()
        {
            InitializeComponent();
            DataTable datatable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT CourseName FROM Course", Form1.connection);
            adapter.Fill(datatable);
            comboBoxCourses.DataSource = datatable;
            comboBoxCourses.DisplayMember = "CourseName";
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int count = 0;
            SqlConnection connection = new SqlConnection(@"Server=LAPTOP-QL8KFE17\SQL;Database=Students;User Id=sa;Password=Qazqaz123.");
            string query = "insert into Student(Name,Surname,BirthDate,RegistrationTime,PhoneNumber,Email,Course) values(@name,@surname,@birthdate,@creationtime,@phone,@email,@course)";
            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@name",textBoxName.Text);
            cmd.Parameters.AddWithValue("@surname", textBoxSurname.Text);
            cmd.Parameters.AddWithValue("@birthdate", dateTimePickerBirthDate.Value.Date);
            cmd.Parameters.AddWithValue("@creationtime", dateTimePickerCurrentDate.Value.Date);
            cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
            cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
            cmd.Parameters.AddWithValue("@course", comboBoxCourses.GetItemText(comboBoxCourses.SelectedItem));


            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            
                foreach(DataRow row in Form1.dt.Rows)
            {
                string name = row["CourseName"].ToString();
                if (comboBoxCourses.GetItemText(comboBoxCourses.SelectedItem) == name)
                {
                    if (row.IsNull("StudentCount")) row["StudentCount"] = 1;
                    else
                    {
                       int num= row.Field<int>("StudentCount");
                        num++;
                        row["StudentCount"]=num.ToString();
                    }
                }
            }
            Form1.adapter.Update(Form1.dt);
           
            this.Close();
        }


    }
}
