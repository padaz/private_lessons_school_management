namespace noam
{
    partial class frmDeleteLesson
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessons)).BeginInit();
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
            this.dataGridViewStudents.Location = new System.Drawing.Point(39, 81);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(363, 324);
            this.dataGridViewStudents.TabIndex = 7;
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
            this.dataGridViewLessons.Location = new System.Drawing.Point(475, 81);
            this.dataGridViewLessons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewLessons.Name = "dataGridViewLessons";
            this.dataGridViewLessons.Size = new System.Drawing.Size(966, 324);
            this.dataGridViewLessons.TabIndex = 8;
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelete.Location = new System.Drawing.Point(863, 495);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 60);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Lesson";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(102, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "בחירת תלמיד";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(814, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "בחירת שיעור למחיקה";
            // 
            // frmDeleteLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1461, 577);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewLessons);
            this.Controls.Add(this.dataGridViewStudents);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDeleteLesson";
            this.Text = "frmDeleteLesson";
            this.Load += new System.EventHandler(this.frmDeleteLesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewLessons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktovet;
        private System.Windows.Forms.DataGridViewTextBoxColumn home_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn yom;
        private System.Windows.Forms.DataGridViewTextBoxColumn mish;
        private System.Windows.Forms.DataGridViewTextBoxColumn shem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tz;
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
    }
}