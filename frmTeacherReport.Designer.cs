namespace noam
{
    partial class frmTeacherReport
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
            this.dataGridViewMorimProject = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLessons = new System.Windows.Forms.DataGridView();
            this.kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mik_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMorimProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessons)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMorimProject
            // 
            this.dataGridViewMorimProject.AllowUserToAddRows = false;
            this.dataGridViewMorimProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMorimProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FirstName,
            this.LastName});
            this.dataGridViewMorimProject.Location = new System.Drawing.Point(46, 63);
            this.dataGridViewMorimProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMorimProject.Name = "dataGridViewMorimProject";
            this.dataGridViewMorimProject.Size = new System.Drawing.Size(344, 363);
            this.dataGridViewMorimProject.TabIndex = 5;
            this.dataGridViewMorimProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMorimProject_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ת\"ז";
            this.id.Name = "id";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "שם פרטי";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "שם משפחה";
            this.LastName.Name = "LastName";
            // 
            // dataGridViewLessons
            // 
            this.dataGridViewLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kod,
            this.teacher_name,
            this.student_name,
            this.mik_name,
            this.kita,
            this.level,
            this.due_date,
            this.start_time,
            this.end_time,
            this.notes});
            this.dataGridViewLessons.Location = new System.Drawing.Point(46, 493);
            this.dataGridViewLessons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewLessons.Name = "dataGridViewLessons";
            this.dataGridViewLessons.Size = new System.Drawing.Size(972, 257);
            this.dataGridViewLessons.TabIndex = 9;
            this.dataGridViewLessons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLessons_CellClick);
            // 
            // kod
            // 
            this.kod.DataPropertyName = "kod";
            this.kod.HeaderText = "קוד שיעור";
            this.kod.Name = "kod";
            this.kod.Visible = false;
            // 
            // teacher_name
            // 
            this.teacher_name.DataPropertyName = "teacher_name";
            this.teacher_name.HeaderText = "שם מורה";
            this.teacher_name.Name = "teacher_name";
            // 
            // student_name
            // 
            this.student_name.DataPropertyName = "student_name";
            this.student_name.HeaderText = "שם תלמיד";
            this.student_name.Name = "student_name";
            // 
            // mik_name
            // 
            this.mik_name.DataPropertyName = "mik";
            this.mik_name.HeaderText = "שם מקצוע";
            this.mik_name.Name = "mik_name";
            // 
            // kita
            // 
            this.kita.DataPropertyName = "kita";
            this.kita.HeaderText = "כיתה";
            this.kita.Name = "kita";
            // 
            // level
            // 
            this.level.DataPropertyName = "level";
            this.level.HeaderText = "רמה";
            this.level.Name = "level";
            // 
            // due_date
            // 
            this.due_date.DataPropertyName = "due_date";
            this.due_date.HeaderText = "תאריך";
            this.due_date.Name = "due_date";
            // 
            // start_time
            // 
            this.start_time.DataPropertyName = "start_time";
            this.start_time.HeaderText = "התחלה";
            this.start_time.Name = "start_time";
            // 
            // end_time
            // 
            this.end_time.DataPropertyName = "end_time";
            this.end_time.HeaderText = "סיום";
            this.end_time.Name = "end_time";
            // 
            // notes
            // 
            this.notes.DataPropertyName = "notes";
            this.notes.HeaderText = "הערות";
            this.notes.Name = "notes";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(641, 191);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 27);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(114, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "בחירת מורה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(710, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "בחירת תאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(481, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 39);
            this.label3.TabIndex = 13;
            this.label3.Text = "דו\"ח השיעורים";
            // 
            // frmTeacherReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1063, 782);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridViewLessons);
            this.Controls.Add(this.dataGridViewMorimProject);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTeacherReport";
            this.Text = "דו\"ח שיעורים למורה";
            this.Load += new System.EventHandler(this.frmTeacherReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMorimProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMorimProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridView dataGridViewLessons;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn due_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn kita;
        private System.Windows.Forms.DataGridViewTextBoxColumn mik_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}