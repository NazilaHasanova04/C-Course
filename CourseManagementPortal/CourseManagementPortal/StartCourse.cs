using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CourseManagementPortal
{
    public partial class StartCourse : Form
    {
        public static DateTime dts, dte;
        public static string cb;
        private bool formLoaded = false;
        public static List<string> cs = new List<string>();
        List<string> list = new List<string>();

        public StartCourse()
        {
            InitializeComponent();
            dts = dateTimePickerStart.Value;
            dte = dateTimePickerEnd.Value;
            cs = list;
            // Initialize comboBoxCourse with course names
            DataTable datatable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT CourseName FROM Course", Form1.connection);
            adapter.Fill(datatable);
            comboBoxCourse.SelectedIndexChanged -= comboBoxCourse_SelectedIndexChanged;
            comboBoxCourse.DataSource = datatable;
            comboBoxCourse.DisplayMember = "CourseName";

            // Attach SelectedIndexChanged event handler for comboBoxCourse
            comboBoxCourse.SelectedIndexChanged += comboBoxCourse_SelectedIndexChanged;
        }
        
        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear previous items in comboBoxTeacher
            comboBoxTeacher.Items.Clear();
            ComboBox cmb = (ComboBox)sender;

            // Check if a course is selected
            if (comboBoxCourse.SelectedItem != null)
            {
                try
                {
                    if(comboBoxCourse.SelectedItem.ToString() == null)
                    {
                        MessageBox.Show("Null");
                    }
                    else
                    {

                        string selectedCourse = comboBoxCourse.GetItemText(comboBoxCourse.SelectedItem);
                        if (selectedCourse.Length == 0) selectedCourse = comboBoxCourse.Text;
                        // Construct SQL query to fetch teachers for the selected course
                        string sql = "SELECT (Name + ' ' + Surname) AS NAME FROM Teacher WHERE Profession = @Profession";

                        // Use SqlCommand and SqlParameter for executing parameterized query
                        using (SqlCommand command = new SqlCommand(sql, Form1.connection))
                        {
                            command.Parameters.AddWithValue("@Profession", selectedCourse);

                            // Use SqlDataAdapter to fill the DataTable with results
                            DataTable datatable2 = new DataTable();
                            SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                            adapter2.Fill(datatable2);
                            var x = datatable2.Rows;
                            // Populate comboBoxTeacher with the retrieved teacher names
                            foreach (DataRow row in datatable2.Rows)
                            {
                                comboBoxTeacher.Items.Add(row["NAME"].ToString());
                            }
                        }
                    }
                    // Get the selected course name
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Handle exception as per your application's requirements
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
        }

        List<DateTime> dates = new List<DateTime>();

        private void comboBoxCourse_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }

        private void comboBoxCourse_Click(object sender, EventArgs e)
        {

        }

       

        private void buttonSubmitCourse_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Form1.dt.Rows)
            {
                string name = row["CourseName"].ToString();
                if (comboBoxCourse.GetItemText(comboBoxCourse.SelectedItem) == name)
                {
                    if (row.IsNull("StudentCount")) row["StudentCount"] = 1;
                    else
                    {
                        int num = row.Field<int>("StudentCount");
                        num=0;
                        row["StudentCount"] = num.ToString();
                    }
                }
            }
            Form1.adapter.Update(Form1.dt);
            var con = Form1.connection;
            SqlCommand cmd = new SqlCommand("INSERT INTO studentsCourses VALUES (@start, @end, @course, @teacher)", con);
            cmd.Parameters.AddWithValue("@start", dateTimePickerStart.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@end", dateTimePickerEnd.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@course", comboBoxCourse.GetItemText(comboBoxCourse.SelectedItem));
            cmd.Parameters.AddWithValue("@teacher", comboBoxTeacher.GetItemText(comboBoxTeacher.SelectedItem));
            con.Open();
            cmd.ExecuteNonQuery();

            SqlCommand cmdd = new SqlCommand($"SELECT StartDate FROM studentsCourses WHERE CourseName=@courseName", con);
            cmdd.Parameters.AddWithValue("@courseName", comboBoxCourse.GetItemText(comboBoxCourse.SelectedItem));
            SqlCommand cmdd2 = new SqlCommand($"SELECT EndDate FROM studentsCourses WHERE CourseName=@courseName", con);
            cmdd2.Parameters.AddWithValue("@courseName", comboBoxCourse.GetItemText(comboBoxCourse.SelectedItem));

            DateTime dateS = Convert.ToDateTime(cmdd.ExecuteScalar().ToString());
            DateTime dateE = Convert.ToDateTime(cmdd2.ExecuteScalar().ToString());

            DateTime StartDate = dateS;
            DateTime EndDate = dateE;
            while (StartDate < EndDate)
            {
                dates.Add(StartDate);

                if (StartDate.DayOfWeek == DayOfWeek.Monday ||
                    StartDate.DayOfWeek == DayOfWeek.Tuesday ||
                    StartDate.DayOfWeek == DayOfWeek.Wednesday)
                {
                    StartDate = StartDate.AddDays(3);
                }
                else
                {
                    StartDate = StartDate.AddDays(4);
                }

                if (StartDate >= EndDate)
                {
                    break;
                }
            }

            string columns = "";
            string cells = "";
            string spaces = "";
            for (int i = 0; i < dates.Count; i++)
            {
                columns += $"[{dates[i].ToString("dd-MM-yyyy")}]";
                cells += "'+'";
                spaces += "' '";
                if (i < dates.Count - 1)
                {
                    columns += ", ";
                    cells += ", ";
                    spaces += ", ";

                }
            }

            string query = $"CREATE TABLE [{comboBoxCourse.GetItemText(comboBoxCourse.SelectedItem)}] (Id INT IDENTITY(1,1) PRIMARY KEY,Name NVARCHAR(100))";
            SqlCommand cmd2 = new SqlCommand(query, con);
            cmd2.ExecuteNonQuery();

            for (int i = 0; i < dates.Count; i++)
            {
                string queryyy = $"ALTER TABLE [{comboBoxCourse.GetItemText(comboBoxCourse.SelectedItem)}] ADD [{dates[i].ToString("dd-MM-yyyy")}] NVARCHAR(100)";
                SqlCommand cmdd3 = new SqlCommand(queryyy, con);
                cmdd3.ExecuteNonQuery();
            }

            string query2 = $"CREATE TABLE [{comboBoxCourse.GetItemText(comboBoxCourse.SelectedItem)}_Notes] (Id INT IDENTITY(1,1) PRIMARY KEY,  Name NVARCHAR(100))";
            SqlCommand cmd3 = new SqlCommand(query2, con);
            cmd3.ExecuteNonQuery();

            for (int i = 0; i < dates.Count; i++)
            {
                string queryyy2 = $"ALTER TABLE [{comboBoxCourse.GetItemText(comboBoxCourse.SelectedItem)}_Notes] ADD [{dates[i].ToString("dd-MM-yyyy")}] NVARCHAR(100)";
                SqlCommand cmdd4 = new SqlCommand(queryyy2, con);
                cmdd4.ExecuteNonQuery();
            }

            List<string> studentNames = new List<string>();
            string value = comboBoxCourse.GetItemText(comboBoxCourse.SelectedItem);
            SqlCommand Cmdd3 = new SqlCommand($"SELECT Name + ' ' + Surname FROM Student WHERE Course=@course", con);
            Cmdd3.Parameters.AddWithValue("@course", value);
            SqlDataReader rd1 = Cmdd3.ExecuteReader();
            while (rd1.Read())
            {
                studentNames.Add(rd1.GetString(0));
            }
            rd1.Close();

            for (int i = 0; i < studentNames.Count; i++)
            {
                SqlCommand command1 = new SqlCommand($"INSERT INTO [{comboBoxCourse.GetItemText(comboBoxCourse.SelectedItem)}] ({columns},Name) VALUES ({cells},@studentname)", con);
                command1.Parameters.AddWithValue("@studentname", studentNames[i]);
                command1.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand($"INSERT INTO [{comboBoxCourse.GetItemText(comboBoxCourse.SelectedItem)}_Notes] ({columns},Name) VALUES ({spaces},@studentname)", con);
                command2.Parameters.AddWithValue("@studentname", studentNames[i]);
                command2.ExecuteNonQuery();
            }

            con.Close();
            Close();
        }
    }
}
