namespace noam
{
    partial class frmPanuiProject
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
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewZmanProject = new System.Windows.Forms.DataGridView();
            this.shaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMorimProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZmanProject)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMorimProject
            // 
            this.dataGridViewMorimProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMorimProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FirstName,
            this.LastName,
            this.Address,
            this.Num1,
            this.Num2});
            this.dataGridViewMorimProject.Location = new System.Drawing.Point(13, 58);
            this.dataGridViewMorimProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMorimProject.Name = "dataGridViewMorimProject";
            this.dataGridViewMorimProject.Size = new System.Drawing.Size(674, 292);
            this.dataGridViewMorimProject.TabIndex = 1;
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
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "כתובת";
            this.Address.Name = "Address";
            // 
            // Num1
            // 
            this.Num1.DataPropertyName = "Num1";
            this.Num1.HeaderText = "טלפון 1";
            this.Num1.Name = "Num1";
            // 
            // Num2
            // 
            this.Num2.DataPropertyName = "Num2";
            this.Num2.HeaderText = "טלפון 2";
            this.Num2.Name = "Num2";
            // 
            // dataGridViewZmanProject
            // 
            this.dataGridViewZmanProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZmanProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shaa,
            this.sunday,
            this.monday,
            this.tuesday,
            this.wednesday,
            this.thursday,
            this.friday,
            this.saturday});
            this.dataGridViewZmanProject.Location = new System.Drawing.Point(731, 58);
            this.dataGridViewZmanProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewZmanProject.Name = "dataGridViewZmanProject";
            this.dataGridViewZmanProject.Size = new System.Drawing.Size(846, 423);
            this.dataGridViewZmanProject.TabIndex = 2;
            this.dataGridViewZmanProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewZmanProject_CellClick);
            // 
            // shaa
            // 
            this.shaa.HeaderText = "שעה";
            this.shaa.Name = "shaa";
            // 
            // sunday
            // 
            this.sunday.HeaderText = "ראשון";
            this.sunday.Name = "sunday";
            // 
            // monday
            // 
            this.monday.HeaderText = "שני";
            this.monday.Name = "monday";
            // 
            // tuesday
            // 
            this.tuesday.HeaderText = "שלישי";
            this.tuesday.Name = "tuesday";
            // 
            // wednesday
            // 
            this.wednesday.HeaderText = "רביעי";
            this.wednesday.Name = "wednesday";
            // 
            // thursday
            // 
            this.thursday.HeaderText = "חמישי";
            this.thursday.Name = "thursday";
            // 
            // friday
            // 
            this.friday.HeaderText = "שישי";
            this.friday.Name = "friday";
            // 
            // saturday
            // 
            this.saturday.HeaderText = "שבת";
            this.saturday.Name = "saturday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(234, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "בחירת מורה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1059, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "שעות העבודה";
            // 
            // frmPanuiProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1590, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewZmanProject);
            this.Controls.Add(this.dataGridViewMorimProject);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPanuiProject";
            this.Text = "frmPanuiProject";
            this.Load += new System.EventHandler(this.frmPanuiProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMorimProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZmanProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMorimProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num2;
        private System.Windows.Forms.DataGridView dataGridViewZmanProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn shaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sunday;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}