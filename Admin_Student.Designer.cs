namespace dazuoye2
{
    partial class Admin_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Student));
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttonselect = new System.Windows.Forms.Button();
            this.buttonchange = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.textBoxsdept = new System.Windows.Forms.TextBox();
            this.textBoxsage = new System.Windows.Forms.TextBox();
            this.textBoxssex = new System.Windows.Forms.TextBox();
            this.textBoxsname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxsno = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet = new dazuoye2.SchoolDataSet();
            this.studentTableAdapter = new dazuoye2.SchoolDataSetTableAdapters.StudentTableAdapter();
            this.buttonempty = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(667, 439);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(49, 55);
            this.buttonclose.TabIndex = 74;
            this.buttonclose.Text = "关闭";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttonselect
            // 
            this.buttonselect.Location = new System.Drawing.Point(525, 442);
            this.buttonselect.Name = "buttonselect";
            this.buttonselect.Size = new System.Drawing.Size(54, 52);
            this.buttonselect.TabIndex = 73;
            this.buttonselect.Text = "查找";
            this.buttonselect.UseVisualStyleBackColor = true;
            this.buttonselect.Click += new System.EventHandler(this.buttonselect_Click);
            // 
            // buttonchange
            // 
            this.buttonchange.Location = new System.Drawing.Point(385, 440);
            this.buttonchange.Name = "buttonchange";
            this.buttonchange.Size = new System.Drawing.Size(50, 54);
            this.buttonchange.TabIndex = 72;
            this.buttonchange.Text = "修改";
            this.buttonchange.UseVisualStyleBackColor = true;
            this.buttonchange.Click += new System.EventHandler(this.buttonchange_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(241, 440);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(53, 52);
            this.buttondelete.TabIndex = 71;
            this.buttondelete.Text = "删除";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(103, 440);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(54, 52);
            this.buttonadd.TabIndex = 70;
            this.buttonadd.Text = "增加";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // textBoxsdept
            // 
            this.textBoxsdept.Location = new System.Drawing.Point(634, 375);
            this.textBoxsdept.Name = "textBoxsdept";
            this.textBoxsdept.Size = new System.Drawing.Size(115, 25);
            this.textBoxsdept.TabIndex = 69;
            // 
            // textBoxsage
            // 
            this.textBoxsage.Location = new System.Drawing.Point(495, 375);
            this.textBoxsage.Name = "textBoxsage";
            this.textBoxsage.Size = new System.Drawing.Size(115, 25);
            this.textBoxsage.TabIndex = 68;
            // 
            // textBoxssex
            // 
            this.textBoxssex.Location = new System.Drawing.Point(354, 375);
            this.textBoxssex.Name = "textBoxssex";
            this.textBoxssex.Size = new System.Drawing.Size(115, 25);
            this.textBoxssex.TabIndex = 67;
            // 
            // textBoxsname
            // 
            this.textBoxsname.Location = new System.Drawing.Point(209, 375);
            this.textBoxsname.Name = "textBoxsname";
            this.textBoxsname.Size = new System.Drawing.Size(115, 25);
            this.textBoxsname.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 65;
            this.label4.Text = "Sdept";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "Sage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "Ssex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "Sname";
            // 
            // textBoxsno
            // 
            this.textBoxsno.Location = new System.Drawing.Point(60, 375);
            this.textBoxsno.Name = "textBoxsno";
            this.textBoxsno.Size = new System.Drawing.Size(115, 25);
            this.textBoxsno.TabIndex = 61;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(100, 347);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(31, 15);
            this.labelid.TabIndex = 60;
            this.labelid.Text = "Sno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.ssexDataGridViewTextBoxColumn,
            this.sageDataGridViewTextBoxColumn,
            this.sdeptDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(781, 301);
            this.dataGridView1.TabIndex = 59;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.snoDataGridViewTextBoxColumn.Width = 125;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "Sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Sname";
            this.snameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ssexDataGridViewTextBoxColumn
            // 
            this.ssexDataGridViewTextBoxColumn.DataPropertyName = "Ssex";
            this.ssexDataGridViewTextBoxColumn.HeaderText = "Ssex";
            this.ssexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ssexDataGridViewTextBoxColumn.Name = "ssexDataGridViewTextBoxColumn";
            this.ssexDataGridViewTextBoxColumn.Width = 125;
            // 
            // sageDataGridViewTextBoxColumn
            // 
            this.sageDataGridViewTextBoxColumn.DataPropertyName = "Sage";
            this.sageDataGridViewTextBoxColumn.HeaderText = "Sage";
            this.sageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sageDataGridViewTextBoxColumn.Name = "sageDataGridViewTextBoxColumn";
            this.sageDataGridViewTextBoxColumn.Width = 125;
            // 
            // sdeptDataGridViewTextBoxColumn
            // 
            this.sdeptDataGridViewTextBoxColumn.DataPropertyName = "Sdept";
            this.sdeptDataGridViewTextBoxColumn.HeaderText = "Sdept";
            this.sdeptDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdeptDataGridViewTextBoxColumn.Name = "sdeptDataGridViewTextBoxColumn";
            this.sdeptDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.schoolDataSet;
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // buttonempty
            // 
            this.buttonempty.Location = new System.Drawing.Point(780, 355);
            this.buttonempty.Name = "buttonempty";
            this.buttonempty.Size = new System.Drawing.Size(51, 58);
            this.buttonempty.TabIndex = 75;
            this.buttonempty.Text = "清空";
            this.buttonempty.UseVisualStyleBackColor = true;
            this.buttonempty.Click += new System.EventHandler(this.buttonempty_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(780, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 55);
            this.button1.TabIndex = 76;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(480, 15);
            this.label5.TabIndex = 77;
            this.label5.Text = "学号不可重复，性别必须为“男”或“女”，年龄必须为大于0的整数！";
            // 
            // Admin_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(887, 566);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonempty);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.buttonselect);
            this.Controls.Add(this.buttonchange);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.textBoxsdept);
            this.Controls.Add(this.textBoxsage);
            this.Controls.Add(this.textBoxssex);
            this.Controls.Add(this.textBoxsname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxsno);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Student";
            this.Load += new System.EventHandler(this.Admin_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button buttonselect;
        private System.Windows.Forms.Button buttonchange;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.TextBox textBoxsdept;
        private System.Windows.Forms.TextBox textBoxsage;
        private System.Windows.Forms.TextBox textBoxssex;
        private System.Windows.Forms.TextBox textBoxsname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxsno;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private SchoolDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonempty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}