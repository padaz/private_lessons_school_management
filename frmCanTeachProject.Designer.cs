namespace noam
{
    partial class frmCanTeachProject
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
            this.tabControlMik = new System.Windows.Forms.TabControl();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMorimProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
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
            this.dataGridViewMorimProject.Location = new System.Drawing.Point(937, 133);
            this.dataGridViewMorimProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMorimProject.Name = "dataGridViewMorimProject";
            this.dataGridViewMorimProject.Size = new System.Drawing.Size(345, 336);
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
            // tabControlMik
            // 
            this.tabControlMik.Location = new System.Drawing.Point(51, 70);
            this.tabControlMik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlMik.Name = "tabControlMik";
            this.tabControlMik.SelectedIndex = 0;
            this.tabControlMik.Size = new System.Drawing.Size(825, 429);
            this.tabControlMik.TabIndex = 9;
            this.tabControlMik.SelectedIndexChanged += new System.EventHandler(this.tabControlMik_SelectedIndexChanged);
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AllowUserToAddRows = false;
            this.dataGridViewInfo.AllowUserToDeleteRows = false;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewInfo.Location = new System.Drawing.Point(78, 133);
            this.dataGridViewInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(750, 296);
            this.dataGridViewInfo.TabIndex = 10;
            this.dataGridViewInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInfo_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(349, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "טבלת רמות לימוד וגיל לכל מקצוע";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1004, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "בחירת מורה";
            // 
            // frmCanTeachProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1304, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.tabControlMik);
            this.Controls.Add(this.dataGridViewMorimProject);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCanTeachProject";
            this.Text = "frmCanTeachProject";
            this.Load += new System.EventHandler(this.frmCanTeachProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMorimProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMorimProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.TabControl tabControlMik;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}