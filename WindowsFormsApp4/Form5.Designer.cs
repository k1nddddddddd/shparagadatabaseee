namespace WindowsFormsApp4
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database21DataSet = new WindowsFormsApp4.database21DataSet();
            this.расписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписаниеTableAdapter = new WindowsFormsApp4.database21DataSetTableAdapters.РасписаниеTableAdapter();
            this.расписаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.расписаниеDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.услугиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.расписаниеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // database21DataSet
            // 
            this.database21DataSet.DataSetName = "database21DataSet";
            this.database21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // расписаниеBindingSource
            // 
            this.расписаниеBindingSource.DataMember = "Расписание";
            this.расписаниеBindingSource.DataSource = this.database21DataSet;
            // 
            // расписаниеTableAdapter
            // 
            this.расписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // расписаниеDataGridViewTextBoxColumn
            // 
            this.расписаниеDataGridViewTextBoxColumn.DataPropertyName = "Расписание";
            this.расписаниеDataGridViewTextBoxColumn.HeaderText = "Расписание";
            this.расписаниеDataGridViewTextBoxColumn.Name = "расписаниеDataGridViewTextBoxColumn";
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            // 
            // услугиDataGridViewTextBoxColumn
            // 
            this.услугиDataGridViewTextBoxColumn.DataPropertyName = "Услуги";
            this.услугиDataGridViewTextBoxColumn.HeaderText = "Услуги";
            this.услугиDataGridViewTextBoxColumn.Name = "услугиDataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private database21DataSet database21DataSet;
        private System.Windows.Forms.BindingSource расписаниеBindingSource;
        private database21DataSetTableAdapters.РасписаниеTableAdapter расписаниеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn расписаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn услугиDataGridViewTextBoxColumn;
    }
}