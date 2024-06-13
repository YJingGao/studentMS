namespace dazuoye2
{
    partial class Admin_Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Course));
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttonselect = new System.Windows.Forms.Button();
            this.buttonchange = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet1 = new dazuoye2.SchoolDataSet1();
            this.courseTableAdapter = new dazuoye2.SchoolDataSet1TableAdapters.CourseTableAdapter();
            this.textBoxcredit = new System.Windows.Forms.TextBox();
            this.textBoxcname = new System.Windows.Forms.TextBox();
            this.labelcredit = new System.Windows.Forms.Label();
            this.labelcpno = new System.Windows.Forms.Label();
            this.labelcname = new System.Windows.Forms.Label();
            this.textBoxcno = new System.Windows.Forms.TextBox();
            this.labelcno = new System.Windows.Forms.Label();
            this.textBoxcpno = new System.Windows.Forms.TextBox();
            this.buttonempty = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(514, 505);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(60, 54);
            this.buttonclose.TabIndex = 79;
            this.buttonclose.Text = "关闭";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttonselect
            // 
            this.buttonselect.Location = new System.Drawing.Point(398, 505);
            this.buttonselect.Name = "buttonselect";
            this.buttonselect.Size = new System.Drawing.Size(54, 52);
            this.buttonselect.TabIndex = 78;
            this.buttonselect.Text = "查找";
            this.buttonselect.UseVisualStyleBackColor = true;
            this.buttonselect.Click += new System.EventHandler(this.buttonselect_Click);
            // 
            // buttonchange
            // 
            this.buttonchange.Location = new System.Drawing.Point(285, 505);
            this.buttonchange.Name = "buttonchange";
            this.buttonchange.Size = new System.Drawing.Size(50, 54);
            this.buttonchange.TabIndex = 77;
            this.buttonchange.Text = "修改";
            this.buttonchange.UseVisualStyleBackColor = true;
            this.buttonchange.Click += new System.EventHandler(this.buttonchange_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(173, 505);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(53, 52);
            this.buttondelete.TabIndex = 76;
            this.buttondelete.Text = "删除";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(62, 503);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(54, 52);
            this.buttonadd.TabIndex = 75;
            this.buttonadd.Text = "增加";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnoDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.cpnoDataGridViewTextBoxColumn,
            this.ccreditDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(774, 342);
            this.dataGridView1.TabIndex = 80;
            // 
            // cnoDataGridViewTextBoxColumn
            // 
            this.cnoDataGridViewTextBoxColumn.DataPropertyName = "Cno";
            this.cnoDataGridViewTextBoxColumn.HeaderText = "Cno";
            this.cnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnoDataGridViewTextBoxColumn.Name = "cnoDataGridViewTextBoxColumn";
            this.cnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "Cname";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "Cname";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cpnoDataGridViewTextBoxColumn
            // 
            this.cpnoDataGridViewTextBoxColumn.DataPropertyName = "Cpno";
            this.cpnoDataGridViewTextBoxColumn.HeaderText = "Cpno";
            this.cpnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpnoDataGridViewTextBoxColumn.Name = "cpnoDataGridViewTextBoxColumn";
            this.cpnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ccreditDataGridViewTextBoxColumn
            // 
            this.ccreditDataGridViewTextBoxColumn.DataPropertyName = "Ccredit";
            this.ccreditDataGridViewTextBoxColumn.HeaderText = "Ccredit";
            this.ccreditDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ccreditDataGridViewTextBoxColumn.Name = "ccreditDataGridViewTextBoxColumn";
            this.ccreditDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.schoolDataSet1;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "SchoolDataSet1";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxcredit
            // 
            this.textBoxcredit.Location = new System.Drawing.Point(530, 434);
            this.textBoxcredit.Name = "textBoxcredit";
            this.textBoxcredit.Size = new System.Drawing.Size(115, 25);
            this.textBoxcredit.TabIndex = 89;
            // 
            // textBoxcname
            // 
            this.textBoxcname.Location = new System.Drawing.Point(193, 434);
            this.textBoxcname.Name = "textBoxcname";
            this.textBoxcname.Size = new System.Drawing.Size(115, 25);
            this.textBoxcname.TabIndex = 87;
            // 
            // labelcredit
            // 
            this.labelcredit.AutoSize = true;
            this.labelcredit.Location = new System.Drawing.Point(570, 395);
            this.labelcredit.Name = "labelcredit";
            this.labelcredit.Size = new System.Drawing.Size(63, 15);
            this.labelcredit.TabIndex = 85;
            this.labelcredit.Text = "Ccredit";
            // 
            // labelcpno
            // 
            this.labelcpno.AutoSize = true;
            this.labelcpno.Location = new System.Drawing.Point(395, 395);
            this.labelcpno.Name = "labelcpno";
            this.labelcpno.Size = new System.Drawing.Size(39, 15);
            this.labelcpno.TabIndex = 84;
            this.labelcpno.Text = "Cpno";
            // 
            // labelcname
            // 
            this.labelcname.AutoSize = true;
            this.labelcname.Location = new System.Drawing.Point(229, 395);
            this.labelcname.Name = "labelcname";
            this.labelcname.Size = new System.Drawing.Size(47, 15);
            this.labelcname.TabIndex = 83;
            this.labelcname.Text = "Cname";
            // 
            // textBoxcno
            // 
            this.textBoxcno.Location = new System.Drawing.Point(34, 434);
            this.textBoxcno.Name = "textBoxcno";
            this.textBoxcno.Size = new System.Drawing.Size(115, 25);
            this.textBoxcno.TabIndex = 82;
            // 
            // labelcno
            // 
            this.labelcno.AutoSize = true;
            this.labelcno.Location = new System.Drawing.Point(70, 395);
            this.labelcno.Name = "labelcno";
            this.labelcno.Size = new System.Drawing.Size(31, 15);
            this.labelcno.TabIndex = 81;
            this.labelcno.Text = "Cno";
            // 
            // textBoxcpno
            // 
            this.textBoxcpno.Location = new System.Drawing.Point(367, 434);
            this.textBoxcpno.Name = "textBoxcpno";
            this.textBoxcpno.Size = new System.Drawing.Size(115, 25);
            this.textBoxcpno.TabIndex = 90;
            // 
            // buttonempty
            // 
            this.buttonempty.Location = new System.Drawing.Point(699, 399);
            this.buttonempty.Name = "buttonempty";
            this.buttonempty.Size = new System.Drawing.Size(55, 60);
            this.buttonempty.TabIndex = 91;
            this.buttonempty.Text = "清空";
            this.buttonempty.UseVisualStyleBackColor = true;
            this.buttonempty.Click += new System.EventHandler(this.buttonempty_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 52);
            this.button1.TabIndex = 92;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(801, 643);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonempty);
            this.Controls.Add(this.textBoxcpno);
            this.Controls.Add(this.textBoxcredit);
            this.Controls.Add(this.textBoxcname);
            this.Controls.Add(this.labelcredit);
            this.Controls.Add(this.labelcpno);
            this.Controls.Add(this.labelcname);
            this.Controls.Add(this.textBoxcno);
            this.Controls.Add(this.labelcno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.buttonselect);
            this.Controls.Add(this.buttonchange);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonadd);
            this.Name = "Admin_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Course";
            this.Load += new System.EventHandler(this.Admin_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button buttonselect;
        private System.Windows.Forms.Button buttonchange;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolDataSet1 schoolDataSet1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private SchoolDataSet1TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxcredit;
        private System.Windows.Forms.TextBox textBoxcname;
        private System.Windows.Forms.Label labelcredit;
        private System.Windows.Forms.Label labelcpno;
        private System.Windows.Forms.Label labelcname;
        private System.Windows.Forms.TextBox textBoxcno;
        private System.Windows.Forms.Label labelcno;
        private System.Windows.Forms.TextBox textBoxcpno;
        private System.Windows.Forms.Button buttonempty;
        private System.Windows.Forms.Button button1;
    }
}