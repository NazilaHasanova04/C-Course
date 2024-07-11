namespace CourseManagementPortal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showStudents = new System.Windows.Forms.Button();
            this.startCourse = new System.Windows.Forms.Button();
            this.buttonStartCourse = new System.Windows.Forms.Button();
            this.buttonUpdateCourse = new System.Windows.Forms.Button();
            this.buttonDeleteCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Course Management System!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(440, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Register now!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 61;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 303);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // showStudents
            // 
            this.showStudents.Location = new System.Drawing.Point(50, 488);
            this.showStudents.Name = "showStudents";
            this.showStudents.Size = new System.Drawing.Size(127, 23);
            this.showStudents.TabIndex = 4;
            this.showStudents.Text = "Show to Admin";
            this.showStudents.UseVisualStyleBackColor = true;
            this.showStudents.Click += new System.EventHandler(this.showStudents_Click);
            // 
            // startCourse
            // 
            this.startCourse.Location = new System.Drawing.Point(839, 488);
            this.startCourse.Name = "startCourse";
            this.startCourse.Size = new System.Drawing.Size(139, 23);
            this.startCourse.TabIndex = 5;
            this.startCourse.Text = "Start a course";
            this.startCourse.UseVisualStyleBackColor = true;
            this.startCourse.Click += new System.EventHandler(this.startCourse_Click);
            // 
            // buttonStartCourse
            // 
            this.buttonStartCourse.Location = new System.Drawing.Point(294, 440);
            this.buttonStartCourse.Name = "buttonStartCourse";
            this.buttonStartCourse.Size = new System.Drawing.Size(113, 23);
            this.buttonStartCourse.TabIndex = 6;
            this.buttonStartCourse.Text = "Create Course";
            this.buttonStartCourse.UseVisualStyleBackColor = true;
            this.buttonStartCourse.Click += new System.EventHandler(this.buttonStartCourse_Click);
            // 
            // buttonUpdateCourse
            // 
            this.buttonUpdateCourse.Location = new System.Drawing.Point(481, 433);
            this.buttonUpdateCourse.Name = "buttonUpdateCourse";
            this.buttonUpdateCourse.Size = new System.Drawing.Size(116, 30);
            this.buttonUpdateCourse.TabIndex = 7;
            this.buttonUpdateCourse.Text = "Update Course";
            this.buttonUpdateCourse.UseVisualStyleBackColor = true;
            this.buttonUpdateCourse.Click += new System.EventHandler(this.buttonUpdateCourse_Click);
            // 
            // buttonDeleteCourse
            // 
            this.buttonDeleteCourse.Location = new System.Drawing.Point(673, 440);
            this.buttonDeleteCourse.Name = "buttonDeleteCourse";
            this.buttonDeleteCourse.Size = new System.Drawing.Size(119, 23);
            this.buttonDeleteCourse.TabIndex = 8;
            this.buttonDeleteCourse.Text = "Delete Course";
            this.buttonDeleteCourse.UseVisualStyleBackColor = true;
            this.buttonDeleteCourse.Click += new System.EventHandler(this.buttonDeleteCourse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 564);
            this.Controls.Add(this.buttonDeleteCourse);
            this.Controls.Add(this.buttonUpdateCourse);
            this.Controls.Add(this.buttonStartCourse);
            this.Controls.Add(this.startCourse);
            this.Controls.Add(this.showStudents);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showStudents;
        private System.Windows.Forms.Button startCourse;
        private System.Windows.Forms.Button buttonStartCourse;
        private System.Windows.Forms.Button buttonUpdateCourse;
        private System.Windows.Forms.Button buttonDeleteCourse;
    }
}

