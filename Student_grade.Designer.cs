namespace dazuoye2
{
    partial class Student_grade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_grade));
            this.buttonclose = new System.Windows.Forms.Button();
            this.schoolDataSet5 = new dazuoye2.SchoolDataSet5();
            this.sCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCTableAdapter = new dazuoye2.SchoolDataSet5TableAdapters.SCTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonavegrade = new System.Windows.Forms.Button();
            this.buttonnograde = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(490, 421);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(67, 55);
            this.buttonclose.TabIndex = 1;
            this.buttonclose.Text = "关闭";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // schoolDataSet5
            // 
            this.schoolDataSet5.DataSetName = "SchoolDataSet5";
            this.schoolDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCBindingSource
            // 
            this.sCBindingSource.DataMember = "SC";
            this.sCBindingSource.DataSource = this.schoolDataSet5;
            // 
            // sCTableAdapter
            // 
            this.sCTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(656, 358);
            this.dataGridView1.TabIndex = 3;
            // 
            // buttonavegrade
            // 
            this.buttonavegrade.Location = new System.Drawing.Point(78, 419);
            this.buttonavegrade.Name = "buttonavegrade";
            this.buttonavegrade.Size = new System.Drawing.Size(121, 58);
            this.buttonavegrade.TabIndex = 4;
            this.buttonavegrade.Text = "平均成绩";
            this.buttonavegrade.UseVisualStyleBackColor = true;
            this.buttonavegrade.Click += new System.EventHandler(this.buttonavegrade_Click);
            // 
            // buttonnograde
            // 
            this.buttonnograde.Location = new System.Drawing.Point(289, 419);
            this.buttonnograde.Name = "buttonnograde";
            this.buttonnograde.Size = new System.Drawing.Size(125, 58);
            this.buttonnograde.TabIndex = 5;
            this.buttonnograde.Text = "不及格成绩";
            this.buttonnograde.UseVisualStyleBackColor = true;
            this.buttonnograde.Click += new System.EventHandler(this.buttonnograde_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(720, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonnograde);
            this.Controls.Add(this.buttonavegrade);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonclose);
            this.Name = "Student_grade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_grade";
            this.Load += new System.EventHandler(this.Student_grade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonclose;
        private SchoolDataSet5 schoolDataSet5;
        private System.Windows.Forms.BindingSource sCBindingSource;
        private SchoolDataSet5TableAdapters.SCTableAdapter sCTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonavegrade;
        private System.Windows.Forms.Button buttonnograde;
        private System.Windows.Forms.Button button1;
    }
}