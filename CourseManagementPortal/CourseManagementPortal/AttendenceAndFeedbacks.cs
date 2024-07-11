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
using System.Windows.Forms.VisualStyles;

namespace CourseManagementPortal
{
    public partial class AttendenceAndFeedbacks : Form
    {
        public static List<DateTime> list;
        SqlConnection con = Form1.connection;
        public static DataGridView dgvAtt;
        public SqlDataAdapter adapter,ad2;
        public DataTable table,tab2;
        public AttendenceAndFeedbacks()
        {
            DataGridViewRow row = Main.dgv.CurrentCell.OwningRow;
            string value = row.Cells["CourseName"].Value.ToString();
            InitializeComponent();

            var con = Form1.connection;
            SqlDataAdapter adapter2 = new SqlDataAdapter($"select * from [{value}]",con);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter2);
            ad2 = adapter2;
            tab2 = dt2;
            foreach (DataColumn col in dt2.Columns)
            {
                if (col.ColumnName == "Name" || col.ColumnName=="Id") 
                {
                    dataGridViewAtt.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = col.ColumnName, HeaderText = col.ColumnName });
                }
                else
                {
                    var buttonColumn = new DataGridViewButtonColumn
                    {
                        DataPropertyName = col.ColumnName,
                        HeaderText = col.ColumnName,
                        FlatStyle = FlatStyle.Flat,
                    };
                    dataGridViewAtt.Columns.Add(buttonColumn);
                }
            }
            dataGridViewAtt.DataSource = dt2;
            dataGridViewAtt.CellFormatting += dataGridViewAtt_CellFormatting;

            dataGridViewAtt.AllowUserToAddRows = false;
            dgvAtt = dataGridViewAtt;
            adapter2.Update(dt2);
            showNotes(dataGridViewNotes);
            this.FormClosing += AttendenceAndFeedbacks_FormClosing;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAtt.CurrentCell.Value.ToString() == "+")
            {
                dataGridViewAtt[e.ColumnIndex, e.RowIndex].Value = "q";

            }
            else
            {
                dataGridViewAtt[e.ColumnIndex, e.RowIndex].Value = "+";

            }
            DataGridViewRow row = Main.dgv.CurrentCell.OwningRow;
            string value = row.Cells["CourseName"].Value.ToString();

            var con = Form1.connection;

            string changed = AttendenceAndFeedbacks.dgvAtt.CurrentCell.Value.ToString();

            string header = AttendenceAndFeedbacks.dgvAtt.CurrentCell.OwningColumn.HeaderText;
            header = header.Replace("/", "-");
            string person = AttendenceAndFeedbacks.dgvAtt.CurrentCell.OwningRow.Cells[0].Value.ToString();

            SqlCommand cmd = new SqlCommand($"UPDATE {value} SET [{header}] = '{changed}' WHERE Name = '{person}'", con);
          

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void showNotes(DataGridView dgv)
        {
            DataGridViewRow row = Main.dgv.CurrentCell.OwningRow;
            string value = row.Cells["CourseName"].Value.ToString();
            string q = $"select * from {value}_Notes";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            dgv.DataSource = dt;
            da.Update(dt);
            adapter = da;
            table = dt;

        }

        private void dataGridViewAtt_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewAtt_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewAtt.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewButtonCell btncell = dataGridViewAtt.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                if (btncell != null)
                {
                    btncell.Style.BackColor = Color.LightGray;
                    btncell.Style.ForeColor = Color.Black;
                    btncell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
                    btncell.Style.Padding = new Padding(2, 2, 2, 2);
                    btncell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void dataGridViewNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewNotes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewAtt_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            ad2.Update(tab2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad2.Update(tab2);
            AttendenceAndFeedbacks.ActiveForm.Close();
        }

        private void AttendenceAndFeedbacks_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;        }

        private void dataGridViewNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            adapter.Update(table);
        }

        private void dataGridViewAtt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ad2.Update(tab2);
        }
    }
}
