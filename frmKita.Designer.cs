namespace noam
{
    partial class frmKita
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
            this.dataGridViewKita = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxKita = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKita)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKita
            // 
            this.dataGridViewKita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.kita});
            this.dataGridViewKita.Location = new System.Drawing.Point(41, 27);
            this.dataGridViewKita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewKita.Name = "dataGridViewKita";
            this.dataGridViewKita.Size = new System.Drawing.Size(154, 211);
            this.dataGridViewKita.TabIndex = 0;
            this.dataGridViewKita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKita_CellClick);
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "קוד";
            this.code.Name = "code";
            this.code.Visible = false;
            // 
            // kita
            // 
            this.kita.DataPropertyName = "class";
            this.kita.HeaderText = "כיתה";
            this.kita.Name = "kita";
            // 
            // textBoxKita
            // 
            this.textBoxKita.Location = new System.Drawing.Point(41, 305);
            this.textBoxKita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKita.Name = "textBoxKita";
            this.textBoxKita.Size = new System.Drawing.Size(154, 27);
            this.textBoxKita.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(272, 27);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(272, 113);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "מחיקה";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(272, 204);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 34);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "כיתה";
            // 
            // frmKita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(455, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxKita);
            this.Controls.Add(this.dataGridViewKita);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKita";
            this.Text = "frmKita";
            this.Load += new System.EventHandler(this.frmKita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKita;
        private System.Windows.Forms.TextBox textBoxKita;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn kita;
        private System.Windows.Forms.Label label1;
    }
}