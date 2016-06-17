namespace noam
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnCanTeach = new System.Windows.Forms.Button();
            this.btnPanui = new System.Windows.Forms.Button();
            this.btnMorim = new System.Windows.Forms.Button();
            this.btnLevels = new System.Windows.Forms.Button();
            this.btnKita = new System.Windows.Forms.Button();
            this.btnMik = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnBigForm = new System.Windows.Forms.Button();
            this.btnDeleteLesson = new System.Windows.Forms.Button();
            this.btnTeacherReport = new System.Windows.Forms.Button();
            this.btnStudentReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCanTeach
            // 
            this.btnCanTeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCanTeach.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanTeach.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCanTeach.Location = new System.Drawing.Point(567, 471);
            this.btnCanTeach.Name = "btnCanTeach";
            this.btnCanTeach.Size = new System.Drawing.Size(138, 56);
            this.btnCanTeach.TabIndex = 0;
            this.btnCanTeach.Text = "מורה יכול ללמד";
            this.btnCanTeach.UseVisualStyleBackColor = false;
            this.btnCanTeach.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPanui
            // 
            this.btnPanui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPanui.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanui.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPanui.Location = new System.Drawing.Point(567, 395);
            this.btnPanui.Name = "btnPanui";
            this.btnPanui.Size = new System.Drawing.Size(138, 56);
            this.btnPanui.TabIndex = 1;
            this.btnPanui.Text = "מורה פנוי";
            this.btnPanui.UseVisualStyleBackColor = false;
            this.btnPanui.Click += new System.EventHandler(this.btnPanui_Click);
            // 
            // btnMorim
            // 
            this.btnMorim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMorim.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorim.ForeColor = System.Drawing.Color.Black;
            this.btnMorim.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMorim.Location = new System.Drawing.Point(10, 12);
            this.btnMorim.Name = "btnMorim";
            this.btnMorim.Size = new System.Drawing.Size(144, 52);
            this.btnMorim.TabIndex = 2;
            this.btnMorim.Text = "מורים";
            this.btnMorim.UseVisualStyleBackColor = false;
            this.btnMorim.Click += new System.EventHandler(this.btnMorim_Click);
            // 
            // btnLevels
            // 
            this.btnLevels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLevels.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevels.ForeColor = System.Drawing.Color.Black;
            this.btnLevels.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLevels.Location = new System.Drawing.Point(10, 92);
            this.btnLevels.Name = "btnLevels";
            this.btnLevels.Size = new System.Drawing.Size(144, 52);
            this.btnLevels.TabIndex = 3;
            this.btnLevels.Text = "רמות לימוד";
            this.btnLevels.UseVisualStyleBackColor = false;
            this.btnLevels.Click += new System.EventHandler(this.btnLevels_Click);
            // 
            // btnKita
            // 
            this.btnKita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnKita.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKita.ForeColor = System.Drawing.Color.Black;
            this.btnKita.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKita.Location = new System.Drawing.Point(10, 172);
            this.btnKita.Name = "btnKita";
            this.btnKita.Size = new System.Drawing.Size(144, 52);
            this.btnKita.TabIndex = 4;
            this.btnKita.Text = "כיתות";
            this.btnKita.UseVisualStyleBackColor = false;
            this.btnKita.Click += new System.EventHandler(this.btnKita_Click);
            // 
            // btnMik
            // 
            this.btnMik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMik.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMik.ForeColor = System.Drawing.Color.Black;
            this.btnMik.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMik.Location = new System.Drawing.Point(10, 258);
            this.btnMik.Name = "btnMik";
            this.btnMik.Size = new System.Drawing.Size(144, 52);
            this.btnMik.TabIndex = 5;
            this.btnMik.Text = "מקצועות";
            this.btnMik.UseVisualStyleBackColor = false;
            this.btnMik.Click += new System.EventHandler(this.btnMik_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStudents.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.Black;
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudents.Location = new System.Drawing.Point(10, 338);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(144, 52);
            this.btnStudents.TabIndex = 6;
            this.btnStudents.Text = "תלמידים";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnBigForm
            // 
            this.btnBigForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBigForm.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBigForm.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBigForm.Location = new System.Drawing.Point(417, 395);
            this.btnBigForm.Name = "btnBigForm";
            this.btnBigForm.Size = new System.Drawing.Size(138, 56);
            this.btnBigForm.TabIndex = 7;
            this.btnBigForm.Text = "צור שיעור";
            this.btnBigForm.UseVisualStyleBackColor = false;
            this.btnBigForm.Click += new System.EventHandler(this.btnBigForm_Click);
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeleteLesson.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLesson.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteLesson.Location = new System.Drawing.Point(417, 471);
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(138, 56);
            this.btnDeleteLesson.TabIndex = 8;
            this.btnDeleteLesson.Text = "בטל שיעור לתלמיד";
            this.btnDeleteLesson.UseVisualStyleBackColor = false;
            this.btnDeleteLesson.Click += new System.EventHandler(this.btnDeleteLesson_Click);
            // 
            // btnTeacherReport
            // 
            this.btnTeacherReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTeacherReport.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherReport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeacherReport.Location = new System.Drawing.Point(724, 471);
            this.btnTeacherReport.Name = "btnTeacherReport";
            this.btnTeacherReport.Size = new System.Drawing.Size(136, 55);
            this.btnTeacherReport.TabIndex = 9;
            this.btnTeacherReport.Text = "דו\"ח מורים";
            this.btnTeacherReport.UseVisualStyleBackColor = false;
            this.btnTeacherReport.Click += new System.EventHandler(this.btnTeacherReport_Click);
            // 
            // btnStudentReport
            // 
            this.btnStudentReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStudentReport.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentReport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudentReport.Location = new System.Drawing.Point(724, 395);
            this.btnStudentReport.Name = "btnStudentReport";
            this.btnStudentReport.Size = new System.Drawing.Size(136, 54);
            this.btnStudentReport.TabIndex = 10;
            this.btnStudentReport.Text = "דו\"ח תלמידים";
            this.btnStudentReport.UseVisualStyleBackColor = false;
            this.btnStudentReport.Click += new System.EventHandler(this.btnStudentReport_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 54F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(-61, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1012, 136);
            this.label1.TabIndex = 11;
            this.label1.Text = "בית ספר למורים פרטיים";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(411, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 159);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnMorim);
            this.panel2.Controls.Add(this.btnStudents);
            this.panel2.Controls.Add(this.btnLevels);
            this.panel2.Controls.Add(this.btnMik);
            this.panel2.Controls.Add(this.btnKita);
            this.panel2.Location = new System.Drawing.Point(66, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 410);
            this.panel2.TabIndex = 13;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 589);
            this.Controls.Add(this.btnBigForm);
            this.Controls.Add(this.btnDeleteLesson);
            this.Controls.Add(this.btnCanTeach);
            this.Controls.Add(this.btnTeacherReport);
            this.Controls.Add(this.btnStudentReport);
            this.Controls.Add(this.btnPanui);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCanTeach;
        private System.Windows.Forms.Button btnPanui;
        private System.Windows.Forms.Button btnMorim;
        private System.Windows.Forms.Button btnLevels;
        private System.Windows.Forms.Button btnKita;
        private System.Windows.Forms.Button btnMik;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnBigForm;
        private System.Windows.Forms.Button btnDeleteLesson;
        private System.Windows.Forms.Button btnTeacherReport;
        private System.Windows.Forms.Button btnStudentReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}