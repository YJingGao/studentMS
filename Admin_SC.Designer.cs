namespace dazuoye2
{
    partial class Admin_SC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_SC));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet3 = new dazuoye2.SchoolDataSet3();
            this.labelsno = new System.Windows.Forms.Label();
            this.labelcno = new System.Windows.Forms.Label();
            this.labelgrade = new System.Windows.Forms.Label();
            this.textBoxsno = new System.Windows.Forms.TextBox();
            this.textBoxcno = new System.Windows.Forms.TextBox();
            this.textBoxgrade = new System.Windows.Forms.TextBox();
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttonselect = new System.Windows.Forms.Button();
            this.buttonchange = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonempty = new System.Windows.Forms.Button();
            this.sCTableAdapter = new dazuoye2.SchoolDataSet3TableAdapters.SCTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet3)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(562, 313);
            this.dataGridView1.TabIndex = 0;
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
            this.sCBindingSource.DataSource = this.schoolDataSet3;
            // 
            // schoolDataSet3
            // 
            this.schoolDataSet3.DataSetName = "SchoolDataSet3";
            this.schoolDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelsno
            // 
            this.labelsno.AutoSize = true;
            this.labelsno.Location = new System.Drawing.Point(61, 351);
            this.labelsno.Name = "labelsno";
            this.labelsno.Size = new System.Drawing.Size(31, 15);
            this.labelsno.TabIndex = 1;
            this.labelsno.Text = "Sno";
            // 
            // labelcno
            // 
            this.labelcno.AutoSize = true;
            this.labelcno.Location = new System.Drawing.Point(210, 351);
            this.labelcno.Name = "labelcno";
            this.labelcno.Size = new System.Drawing.Size(31, 15);
            this.labelcno.TabIndex = 2;
            this.labelcno.Text = "Cno";
            // 
            // labelgrade
            // 
            this.labelgrade.AutoSize = true;
            this.labelgrade.Location = new System.Drawing.Point(353, 351);
            this.labelgrade.Name = "labelgrade";
            this.labelgrade.Size = new System.Drawing.Size(47, 15);
            this.labelgrade.TabIndex = 3;
            this.labelgrade.Text = "Grade";
            // 
            // textBoxsno
            // 
            this.textBoxsno.Location = new System.Drawing.Point(30, 383);
            this.textBoxsno.Name = "textBoxsno";
            this.textBoxsno.Size = new System.Drawing.Size(100, 25);
            this.textBoxsno.TabIndex = 4;
            // 
            // textBoxcno
            // 
            this.textBoxcno.Location = new System.Drawing.Point(181, 383);
            this.textBoxcno.Name = "textBoxcno";
            this.textBoxcno.Size = new System.Drawing.Size(100, 25);
            this.textBoxcno.TabIndex = 5;
            // 
            // textBoxgrade
            // 
            this.textBoxgrade.Location = new System.Drawing.Point(327, 383);
            this.textBoxgrade.Name = "textBoxgrade";
            this.textBoxgrade.Size = new System.Drawing.Size(100, 25);
            this.textBoxgrade.TabIndex = 6;
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(424, 438);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(54, 53);
            this.buttonclose.TabIndex = 79;
            this.buttonclose.Text = "关闭";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttonselect
            // 
            this.buttonselect.Location = new System.Drawing.Point(327, 439);
            this.buttonselect.Name = "buttonselect";
            this.buttonselect.Size = new System.Drawing.Size(54, 52);
            this.buttonselect.TabIndex = 78;
            this.buttonselect.Text = "查找";
            this.buttonselect.UseVisualStyleBackColor = true;
            this.buttonselect.Click += new System.EventHandler(this.buttonselect_Click);
            // 
            // buttonchange
            // 
            this.buttonchange.Location = new System.Drawing.Point(231, 439);
            this.buttonchange.Name = "buttonchange";
            this.buttonchange.Size = new System.Drawing.Size(50, 54);
            this.buttonchange.TabIndex = 77;
            this.buttonchange.Text = "修改";
            this.buttonchange.UseVisualStyleBackColor = true;
            this.buttonchange.Click += new System.EventHandler(this.buttonchange_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(131, 439);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(53, 52);
            this.buttondelete.TabIndex = 76;
            this.buttondelete.Text = "删除";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(30, 439);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(54, 52);
            this.buttonadd.TabIndex = 75;
            this.buttonadd.Text = "增加";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonempty
            // 
            this.buttonempty.Location = new System.Drawing.Point(478, 358);
            this.buttonempty.Name = "buttonempty";
            this.buttonempty.Size = new System.Drawing.Size(58, 50);
            this.buttonempty.TabIndex = 80;
            this.buttonempty.Text = "清除";
            this.buttonempty.UseVisualStyleBackColor = true;
            this.buttonempty.Click += new System.EventHandler(this.buttonempty_Click);
            // 
            // sCTableAdapter
            // 
            this.sCTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 55);
            this.button1.TabIndex = 81;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 15);
            this.label1.TabIndex = 82;
            this.label1.Text = "如果要进行查找成绩的相关操作，请先点击查找按钮，进入下一个界面！";
            // 
            // Admin_SC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(623, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonempty);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.buttonselect);
            this.Controls.Add(this.buttonchange);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.textBoxgrade);
            this.Controls.Add(this.textBoxcno);
            this.Controls.Add(this.textBoxsno);
            this.Controls.Add(this.labelgrade);
            this.Controls.Add(this.labelcno);
            this.Controls.Add(this.labelsno);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_SC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_SC";
            this.Load += new System.EventHandler(this.Admin_SC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelsno;
        private System.Windows.Forms.Label labelcno;
        private System.Windows.Forms.Label labelgrade;
        private System.Windows.Forms.TextBox textBoxsno;
        private System.Windows.Forms.TextBox textBoxcno;
        private System.Windows.Forms.TextBox textBoxgrade;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button buttonselect;
        private System.Windows.Forms.Button buttonchange;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonempty;
        private SchoolDataSet3 schoolDataSet3;
        private System.Windows.Forms.BindingSource sCBindingSource;
        private SchoolDataSet3TableAdapters.SCTableAdapter sCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}