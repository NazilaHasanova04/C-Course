namespace CourseManagementPortal
{
    partial class AttendenceAndFeedbacks
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewAtt = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewNotes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtt)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 534);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewAtt);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1073, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAtt
            // 
            this.dataGridViewAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAtt.Location = new System.Drawing.Point(6, 18);
            this.dataGridViewAtt.Name = "dataGridViewAtt";
            this.dataGridViewAtt.RowHeadersWidth = 51;
            this.dataGridViewAtt.RowTemplate.Height = 24;
            this.dataGridViewAtt.Size = new System.Drawing.Size(1061, 481);
            this.dataGridViewAtt.TabIndex = 0;
            this.dataGridViewAtt.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewAtt_CellBeginEdit);
            this.dataGridViewAtt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAtt_CellClick);
            this.dataGridViewAtt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewAtt.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAtt_CellFormatting);
            this.dataGridViewAtt.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAtt_CellValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewNotes);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1073, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNotes
            // 
            this.dataGridViewNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotes.Location = new System.Drawing.Point(21, 17);
            this.dataGridViewNotes.Name = "dataGridViewNotes";
            this.dataGridViewNotes.RowHeadersWidth = 51;
            this.dataGridViewNotes.RowTemplate.Height = 24;
            this.dataGridViewNotes.Size = new System.Drawing.Size(1089, 519);
            this.dataGridViewNotes.TabIndex = 0;
            this.dataGridViewNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotes_CellClick);
            this.dataGridViewNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotes_CellContentClick);
            this.dataGridViewNotes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotes_CellValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AttendenceAndFeedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AttendenceAndFeedbacks";
            this.Text = "AttendenceAndFeedbacks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AttendenceAndFeedbacks_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtt)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewAtt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewNotes;
        private System.Windows.Forms.Button button1;
    }
}