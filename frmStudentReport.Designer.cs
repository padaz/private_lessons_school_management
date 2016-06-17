namespace noam
{
    partial class frmStudentReport
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.tz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktovet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLessonsPast = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewLessonsFuture = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessonsPast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessonsFuture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tz,
            this.shem,
            this.mish,
            this.yom,
            this.mobile_telephone,
            this.home_telephone,
            this.ktovet});
            this.dataGridViewStudents.Location = new System.Drawing.Point(18, 54);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(769, 324);
            this.dataGridViewStudents.TabIndex = 8;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            // 
            // tz
            // 
            this.tz.DataPropertyName = "tz";
            this.tz.HeaderText = "ת\"ז";
            this.tz.Name = "tz";
            // 
            // shem
            // 
            this.shem.DataPropertyName = "shem";
            this.shem.HeaderText = "שם פרטי";
            this.shem.Name = "shem";
            // 
            // mish
            // 
            this.mish.DataPropertyName = "mish";
            this.mish.HeaderText = "שם משפחה";
            this.mish.Name = "mish";
            // 
            // yom
            // 
            this.yom.DataPropertyName = "yom";
            this.yom.HeaderText = "תאריך לידה";
            this.yom.Name = "yom";
            // 
            // mobile_telephone
            // 
            this.mobile_telephone.DataPropertyName = "mobile_telephone";
            this.mobile_telephone.HeaderText = "טלפון סלולרי";
            this.mobile_telephone.Name = "mobile_telephone";
            // 
            // home_telephone
            // 
            this.home_telephone.DataPropertyName = "home_telephone";
            this.home_telephone.HeaderText = "טלפון בבית";
            this.home_telephone.Name = "home_telephone";
            // 
            // ktovet
            // 
            this.ktovet.DataPropertyName = "ktovet";
            this.ktovet.HeaderText = "כתובת";
            this.ktovet.Name = "ktovet";
            // 
            // dataGridViewLessonsPast
            // 
            this.dataGridViewLessonsPast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLessonsPast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewLessonsPast.Location = new System.Drawing.Point(18, 430);
            this.dataGridViewLessonsPast.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLessonsPast.Name = "dataGridViewLessonsPast";
            this.dataGridViewLessonsPast.Size = new System.Drawing.Size(951, 200);
            this.dataGridViewLessonsPast.TabIndex = 9;
            this.dataGridViewLessonsPast.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLessonsPast_CellClick);
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
            // dataGridViewLessonsFuture
            // 
            this.dataGridViewLessonsFuture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLessonsFuture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridViewLessonsFuture.Location = new System.Drawing.Point(18, 671);
            this.dataGridViewLessonsFuture.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLessonsFuture.Name = "dataGridViewLessonsFuture";
            this.dataGridViewLessonsFuture.Size = new System.Drawing.Size(951, 237);
            this.dataGridViewLessonsFuture.TabIndex = 10;
            this.dataGridViewLessonsFuture.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLessonsFuture_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kod";
            this.dataGridViewTextBoxColumn1.HeaderText = "קוד שיעור";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "teacher_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "שם מורה";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "student_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "שם תלמיד";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "mik";
            this.dataGridViewTextBoxColumn4.HeaderText = "שם מקצוע";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "kita";
            this.dataGridViewTextBoxColumn5.HeaderText = "כיתה";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "level";
            this.dataGridViewTextBoxColumn6.HeaderText = "רמה";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "due_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "תאריך";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "start_time";
            this.dataGridViewTextBoxColumn8.HeaderText = "התחלה";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "end_time";
            this.dataGridViewTextBoxColumn9.HeaderText = "סיום";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "notes";
            this.dataGridViewTextBoxColumn10.HeaderText = "הערות";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "דו\"ח שיעורים בעבר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(417, 634);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "דו\"ח שיעורים בעתיד";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "בחירת תלמיד";
            // 
            // frmStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1015, 921);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLessonsFuture);
            this.Controls.Add(this.dataGridViewLessonsPast);
            this.Controls.Add(this.dataGridViewStudents);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudentReport";
            this.Text = "frmStudentReport";
            this.Load += new System.EventHandler(this.frmStudentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessonsPast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessonsFuture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewLessonsPast;
        private System.Windows.Forms.DataGridView dataGridViewLessonsFuture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ktovet;
        private System.Windows.Forms.DataGridViewTextBoxColumn home_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn yom;
        private System.Windows.Forms.DataGridViewTextBoxColumn mish;
        private System.Windows.Forms.DataGridViewTextBoxColumn shem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tz;
        private System.Windows.Forms.Label label3;
    }
}