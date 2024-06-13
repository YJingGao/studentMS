namespace dazuoye2
{
    partial class Admin_SC_grade
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_SC_grade));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet7 = new dazuoye2.SchoolDataSet7();
            this.textBoxcno = new System.Windows.Forms.TextBox();
            this.textBoxsno = new System.Windows.Forms.TextBox();
            this.labelcno = new System.Windows.Forms.Label();
            this.labelsno = new System.Windows.Forms.Label();
            this.textBoxgrade = new System.Windows.Forms.TextBox();
            this.labelgrade = new System.Windows.Forms.Label();
            this.buttonnograde = new System.Windows.Forms.Button();
            this.buttonselect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonclear = new System.Windows.Forms.Button();
            this.textBoxmin = new System.Windows.Forms.TextBox();
            this.textBoxmax = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.sCTableAdapter = new dazuoye2.SchoolDataSet7TableAdapters.SCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.cnoDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sCBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(459, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.snoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cnoDataGridViewTextBoxColumn
            // 
            this.cnoDataGridViewTextBoxColumn.DataPropertyName = "Cno";
            this.cnoDataGridViewTextBoxColumn.HeaderText = "Cno";
            this.cnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnoDataGridViewTextBoxColumn.Name = "cnoDataGridViewTextBoxColumn";
            this.cnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sCBindingSource
            // 
            this.sCBindingSource.DataMember = "SC";
            this.sCBindingSource.DataSource = this.schoolDataSet7;
            // 
            // schoolDataSet7
            // 
            this.schoolDataSet7.DataSetName = "SchoolDataSet7";
            this.schoolDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxcno
            // 
            this.textBoxcno.Location = new System.Drawing.Point(193, 343);
            this.textBoxcno.Name = "textBoxcno";
            this.textBoxcno.Size = new System.Drawing.Size(100, 25);
            this.textBoxcno.TabIndex = 9;
            this.textBoxcno.TextChanged += new System.EventHandler(this.textBoxcno_TextChanged);
            // 
            // textBoxsno
            // 
            this.textBoxsno.Location = new System.Drawing.Point(42, 343);
            this.textBoxsno.Name = "textBoxsno";
            this.textBoxsno.Size = new System.Drawing.Size(100, 25);
            this.textBoxsno.TabIndex = 8;
            this.textBoxsno.TextChanged += new System.EventHandler(this.textBoxsno_TextChanged);
            // 
            // labelcno
            // 
            this.labelcno.AutoSize = true;
            this.labelcno.Location = new System.Drawing.Point(222, 311);
            this.labelcno.Name = "labelcno";
            this.labelcno.Size = new System.Drawing.Size(31, 15);
            this.labelcno.TabIndex = 7;
            this.labelcno.Text = "Cno";
            this.labelcno.Click += new System.EventHandler(this.labelcno_Click);
            // 
            // labelsno
            // 
            this.labelsno.AutoSize = true;
            this.labelsno.Location = new System.Drawing.Point(73, 311);
            this.labelsno.Name = "labelsno";
            this.labelsno.Size = new System.Drawing.Size(31, 15);
            this.labelsno.TabIndex = 6;
            this.labelsno.Text = "Sno";
            this.labelsno.Click += new System.EventHandler(this.labelsno_Click);
            // 
            // textBoxgrade
            // 
            this.textBoxgrade.Location = new System.Drawing.Point(356, 339);
            this.textBoxgrade.Name = "textBoxgrade";
            this.textBoxgrade.Size = new System.Drawing.Size(100, 25);
            this.textBoxgrade.TabIndex = 11;
            this.textBoxgrade.TextChanged += new System.EventHandler(this.textBoxgrade_TextChanged);
            // 
            // labelgrade
            // 
            this.labelgrade.AutoSize = true;
            this.labelgrade.Location = new System.Drawing.Point(382, 307);
            this.labelgrade.Name = "labelgrade";
            this.labelgrade.Size = new System.Drawing.Size(47, 15);
            this.labelgrade.TabIndex = 10;
            this.labelgrade.Text = "Grade";
            this.labelgrade.Click += new System.EventHandler(this.labelgrade_Click);
            // 
            // buttonnograde
            // 
            this.buttonnograde.Location = new System.Drawing.Point(42, 418);
            this.buttonnograde.Name = "buttonnograde";
            this.buttonnograde.Size = new System.Drawing.Size(100, 51);
            this.buttonnograde.TabIndex = 12;
            this.buttonnograde.Text = "不及格成绩";
            this.buttonnograde.UseVisualStyleBackColor = true;
            this.buttonnograde.Click += new System.EventHandler(this.buttonnograde_Click);
            // 
            // buttonselect
            // 
            this.buttonselect.Location = new System.Drawing.Point(239, 420);
            this.buttonselect.Name = "buttonselect";
            this.buttonselect.Size = new System.Drawing.Size(76, 49);
            this.buttonselect.TabIndex = 13;
            this.buttonselect.Text = "查找";
            this.buttonselect.UseVisualStyleBackColor = true;
            this.buttonselect.Click += new System.EventHandler(this.buttonselect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(601, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 50);
            this.button2.TabIndex = 15;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "最低分：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "最高分：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(541, 320);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(57, 48);
            this.buttonclear.TabIndex = 20;
            this.buttonclear.Text = "清除";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // textBoxmin
            // 
            this.textBoxmin.Location = new System.Drawing.Point(621, 40);
            this.textBoxmin.Name = "textBoxmin";
            this.textBoxmin.Size = new System.Drawing.Size(100, 25);
            this.textBoxmin.TabIndex = 21;
            this.textBoxmin.TextChanged += new System.EventHandler(this.textBoxmin_TextChanged);
            // 
            // textBoxmax
            // 
            this.textBoxmax.Location = new System.Drawing.Point(621, 105);
            this.textBoxmax.Name = "textBoxmax";
            this.textBoxmax.Size = new System.Drawing.Size(100, 25);
            this.textBoxmax.TabIndex = 22;
            this.textBoxmax.TextChanged += new System.EventHandler(this.textBoxmax_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(621, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 54);
            this.button3.TabIndex = 23;
            this.button3.Text = "分数段查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sCTableAdapter
            // 
            this.sCTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_SC_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(813, 523);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxmax);
            this.Controls.Add(this.textBoxmin);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonselect);
            this.Controls.Add(this.buttonnograde);
            this.Controls.Add(this.textBoxgrade);
            this.Controls.Add(this.labelgrade);
            this.Controls.Add(this.textBoxcno);
            this.Controls.Add(this.textBoxsno);
            this.Controls.Add(this.labelcno);
            this.Controls.Add(this.labelsno);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_SC_grade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_SC_grade";
            this.Load += new System.EventHandler(this.Admin_SC_grade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxcno;
        private System.Windows.Forms.TextBox textBoxsno;
        private System.Windows.Forms.Label labelcno;
        private System.Windows.Forms.Label labelsno;
        private System.Windows.Forms.TextBox textBoxgrade;
        private System.Windows.Forms.Label labelgrade;
        private System.Windows.Forms.Button buttonnograde;
        private System.Windows.Forms.Button buttonselect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.TextBox textBoxmin;
        private System.Windows.Forms.TextBox textBoxmax;
        private System.Windows.Forms.Button button3;
        private SchoolDataSet7 schoolDataSet7;
        private System.Windows.Forms.BindingSource sCBindingSource;
        private SchoolDataSet7TableAdapters.SCTableAdapter sCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
    }
}