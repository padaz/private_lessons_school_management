namespace noam
{
    partial class frmStudents
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
            this.textBoxTZ = new System.Windows.Forms.TextBox();
            this.textBoxShem = new System.Windows.Forms.TextBox();
            this.textBoxMish = new System.Windows.Forms.TextBox();
            this.textBoxHome = new System.Windows.Forms.TextBox();
            this.textBoxKtovet = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.dateTimePickerBday = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
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
            this.dataGridViewStudents.Location = new System.Drawing.Point(224, 132);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(819, 412);
            this.dataGridViewStudents.TabIndex = 0;
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
            // textBoxTZ
            // 
            this.textBoxTZ.Location = new System.Drawing.Point(64, 579);
            this.textBoxTZ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTZ.Name = "textBoxTZ";
            this.textBoxTZ.Size = new System.Drawing.Size(136, 27);
            this.textBoxTZ.TabIndex = 1;
            // 
            // textBoxShem
            // 
            this.textBoxShem.Location = new System.Drawing.Point(224, 579);
            this.textBoxShem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxShem.Name = "textBoxShem";
            this.textBoxShem.Size = new System.Drawing.Size(144, 27);
            this.textBoxShem.TabIndex = 2;
            // 
            // textBoxMish
            // 
            this.textBoxMish.Location = new System.Drawing.Point(400, 579);
            this.textBoxMish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMish.Name = "textBoxMish";
            this.textBoxMish.Size = new System.Drawing.Size(129, 27);
            this.textBoxMish.TabIndex = 3;
            // 
            // textBoxHome
            // 
            this.textBoxHome.Location = new System.Drawing.Point(982, 577);
            this.textBoxHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxHome.Name = "textBoxHome";
            this.textBoxHome.Size = new System.Drawing.Size(125, 27);
            this.textBoxHome.TabIndex = 5;
            // 
            // textBoxKtovet
            // 
            this.textBoxKtovet.Location = new System.Drawing.Point(1130, 577);
            this.textBoxKtovet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKtovet.Name = "textBoxKtovet";
            this.textBoxKtovet.Size = new System.Drawing.Size(131, 27);
            this.textBoxKtovet.TabIndex = 6;
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(822, 577);
            this.textBoxMobile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(141, 27);
            this.textBoxMobile.TabIndex = 7;
            // 
            // dateTimePickerBday
            // 
            this.dateTimePickerBday.Location = new System.Drawing.Point(552, 579);
            this.dateTimePickerBday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerBday.Name = "dateTimePickerBday";
            this.dateTimePickerBday.Size = new System.Drawing.Size(246, 27);
            this.dateTimePickerBday.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1074, 132);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 79);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1074, 308);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 73);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "מחק";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1074, 478);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(159, 66);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(229, 81);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(148, 27);
            this.textBoxFind.TabIndex = 13;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 617);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "תעודת זהות";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 617);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "שם פרטי";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 617);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "שם משפחה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 617);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "תאריך לידה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(838, 608);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "טלפון סלולרי";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1003, 608);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "טלפון בבית";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1178, 608);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "כתובת";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "תיבת חיפוש";
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1274, 760);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePickerBday);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.textBoxKtovet);
            this.Controls.Add(this.textBoxHome);
            this.Controls.Add(this.textBoxMish);
            this.Controls.Add(this.textBoxShem);
            this.Controls.Add(this.textBoxTZ);
            this.Controls.Add(this.dataGridViewStudents);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStudents";
            this.Text = "frmStudents";
            this.Load += new System.EventHandler(this.frmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.TextBox textBoxTZ;
        private System.Windows.Forms.TextBox textBoxShem;
        private System.Windows.Forms.TextBox textBoxMish;
        private System.Windows.Forms.TextBox textBoxHome;
        private System.Windows.Forms.TextBox textBoxKtovet;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.DateTimePicker dateTimePickerBday;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktovet;
        private System.Windows.Forms.DataGridViewTextBoxColumn home_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn yom;
        private System.Windows.Forms.DataGridViewTextBoxColumn mish;
        private System.Windows.Forms.DataGridViewTextBoxColumn shem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tz;
        private System.Windows.Forms.Label label8;
    }
}