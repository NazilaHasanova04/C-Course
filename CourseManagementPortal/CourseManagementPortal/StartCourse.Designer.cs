namespace CourseManagementPortal
{
    partial class StartCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonSubmitCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start a new Course!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Teacher Name";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.BackColor = System.Drawing.Color.Silver;
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Items.AddRange(new object[] {
            "Maths",
            "Physics",
            "Chemistry",
            "English",
            "Programming"});
            this.comboBoxCourse.Location = new System.Drawing.Point(401, 217);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(180, 24);
            this.comboBoxCourse.TabIndex = 6;
            this.comboBoxCourse.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxCourse_DrawItem);
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            this.comboBoxCourse.Click += new System.EventHandler(this.comboBoxCourse_Click);
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.BackColor = System.Drawing.Color.Silver;
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Items.AddRange(new object[] {
            "Gulshan Hasanova",
            "Elchin Abdullayev",
            "Ali Quliyev",
            "Sabina Ibadova",
            "Sabuhi Sultanov",
            "Ceyhun Huseynov",
            "Sevda Musayeva"});
            this.comboBoxTeacher.Location = new System.Drawing.Point(412, 275);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(169, 24);
            this.comboBoxTeacher.TabIndex = 7;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(381, 97);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStart.TabIndex = 8;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(393, 153);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(188, 22);
            this.dateTimePickerEnd.TabIndex = 9;
            // 
            // buttonSubmitCourse
            // 
            this.buttonSubmitCourse.Location = new System.Drawing.Point(367, 379);
            this.buttonSubmitCourse.Name = "buttonSubmitCourse";
            this.buttonSubmitCourse.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitCourse.TabIndex = 10;
            this.buttonSubmitCourse.Text = "Submit";
            this.buttonSubmitCourse.UseVisualStyleBackColor = true;
            this.buttonSubmitCourse.Click += new System.EventHandler(this.buttonSubmitCourse_Click);
            // 
            // StartCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 566);
            this.Controls.Add(this.buttonSubmitCourse);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartCourse";
            this.Text = "StartCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonSubmitCourse;
    }
}