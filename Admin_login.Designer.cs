namespace dazuoye2
{
    partial class Admin_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_login));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userOperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet2 = new dazuoye2.SchoolDataSet2();
            this.sysLogTableAdapter = new dazuoye2.SchoolDataSet2TableAdapters.SysLogTableAdapter();
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttonchange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.dateAndTimeDataGridViewTextBoxColumn,
            this.userOperationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sysLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(757, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateAndTimeDataGridViewTextBoxColumn
            // 
            this.dateAndTimeDataGridViewTextBoxColumn.DataPropertyName = "DateAndTime";
            this.dateAndTimeDataGridViewTextBoxColumn.HeaderText = "DateAndTime";
            this.dateAndTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAndTimeDataGridViewTextBoxColumn.Name = "dateAndTimeDataGridViewTextBoxColumn";
            this.dateAndTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // userOperationDataGridViewTextBoxColumn
            // 
            this.userOperationDataGridViewTextBoxColumn.DataPropertyName = "UserOperation";
            this.userOperationDataGridViewTextBoxColumn.HeaderText = "UserOperation";
            this.userOperationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userOperationDataGridViewTextBoxColumn.Name = "userOperationDataGridViewTextBoxColumn";
            this.userOperationDataGridViewTextBoxColumn.Width = 125;
            // 
            // sysLogBindingSource
            // 
            this.sysLogBindingSource.DataMember = "SysLog";
            this.sysLogBindingSource.DataSource = this.schoolDataSet2;
            // 
            // schoolDataSet2
            // 
            this.schoolDataSet2.DataSetName = "SchoolDataSet2";
            this.schoolDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sysLogTableAdapter
            // 
            this.sysLogTableAdapter.ClearBeforeFill = true;
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(530, 408);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(56, 47);
            this.buttonclose.TabIndex = 1;
            this.buttonclose.Text = "关闭";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttonchange
            // 
            this.buttonchange.Location = new System.Drawing.Point(354, 408);
            this.buttonchange.Name = "buttonchange";
            this.buttonchange.Size = new System.Drawing.Size(59, 47);
            this.buttonchange.TabIndex = 2;
            this.buttonchange.Text = "刷新";
            this.buttonchange.UseVisualStyleBackColor = true;
            this.buttonchange.Click += new System.EventHandler(this.buttonchange_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(823, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonchange);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_login_FormClosed);
            this.Load += new System.EventHandler(this.Admin_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolDataSet2 schoolDataSet2;
        private System.Windows.Forms.BindingSource sysLogBindingSource;
        private SchoolDataSet2TableAdapters.SysLogTableAdapter sysLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userOperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button buttonchange;
        private System.Windows.Forms.Button button1;
    }
}