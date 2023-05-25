namespace WindowsFormsApp4
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database21DataSet = new WindowsFormsApp4.database21DataSet();
            this.ногтевойСервисBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ногтевой_сервисTableAdapter = new WindowsFormsApp4.database21DataSetTableAdapters.Ногтевой_сервисTableAdapter();
            this.ногтевойСервисDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продолжительностьУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ногтевойСервисBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ногтевойСервисDataGridViewTextBoxColumn,
            this.стоимостьУслугиDataGridViewTextBoxColumn,
            this.продолжительностьУслугиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ногтевойСервисBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(106, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // database21DataSet
            // 
            this.database21DataSet.DataSetName = "database21DataSet";
            this.database21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ногтевойСервисBindingSource
            // 
            this.ногтевойСервисBindingSource.DataMember = "Ногтевой сервис";
            this.ногтевойСервисBindingSource.DataSource = this.database21DataSet;
            // 
            // ногтевой_сервисTableAdapter
            // 
            this.ногтевой_сервисTableAdapter.ClearBeforeFill = true;
            // 
            // ногтевойСервисDataGridViewTextBoxColumn
            // 
            this.ногтевойСервисDataGridViewTextBoxColumn.DataPropertyName = "Ногтевой сервис";
            this.ногтевойСервисDataGridViewTextBoxColumn.HeaderText = "Ногтевой сервис";
            this.ногтевойСервисDataGridViewTextBoxColumn.Name = "ногтевойСервисDataGridViewTextBoxColumn";
            // 
            // стоимостьУслугиDataGridViewTextBoxColumn
            // 
            this.стоимостьУслугиDataGridViewTextBoxColumn.DataPropertyName = "Стоимость услуги";
            this.стоимостьУслугиDataGridViewTextBoxColumn.HeaderText = "Стоимость услуги";
            this.стоимостьУслугиDataGridViewTextBoxColumn.Name = "стоимостьУслугиDataGridViewTextBoxColumn";
            // 
            // продолжительностьУслугиDataGridViewTextBoxColumn
            // 
            this.продолжительностьУслугиDataGridViewTextBoxColumn.DataPropertyName = "Продолжительность услуги";
            this.продолжительностьУслугиDataGridViewTextBoxColumn.HeaderText = "Продолжительность услуги";
            this.продолжительностьУслугиDataGridViewTextBoxColumn.Name = "продолжительностьУслугиDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ногтевойСервисBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private database21DataSet database21DataSet;
        private System.Windows.Forms.BindingSource ногтевойСервисBindingSource;
        private database21DataSetTableAdapters.Ногтевой_сервисTableAdapter ногтевой_сервисTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ногтевойСервисDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продолжительностьУслугиDataGridViewTextBoxColumn;
    }
}