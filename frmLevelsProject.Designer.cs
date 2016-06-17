namespace noam
{
    partial class frmLevelsProject
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
            this.dataGridViewLevels = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLevels
            // 
            this.dataGridViewLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLevels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.levels});
            this.dataGridViewLevels.Location = new System.Drawing.Point(34, 42);
            this.dataGridViewLevels.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLevels.Name = "dataGridViewLevels";
            this.dataGridViewLevels.Size = new System.Drawing.Size(144, 262);
            this.dataGridViewLevels.TabIndex = 0;
            this.dataGridViewLevels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLevels_CellClick);
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "קוד";
            this.code.Name = "code";
            this.code.Visible = false;
            // 
            // levels
            // 
            this.levels.DataPropertyName = "rama";
            this.levels.HeaderText = "רמת לימוד";
            this.levels.Name = "levels";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(239, 74);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(239, 163);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "מחיקה";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(239, 259);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Location = new System.Drawing.Point(34, 355);
            this.textBoxLevel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(157, 27);
            this.textBoxLevel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 332);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "רמת לימוד";
            // 
            // frmLevelsProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(404, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewLevels);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLevelsProject";
            this.Text = "frmLevels";
            this.Load += new System.EventHandler(this.frmLevelsProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLevels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLevels;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn levels;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.Label label1;
    }
}