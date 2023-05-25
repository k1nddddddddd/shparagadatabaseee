namespace WindowsFormsApp4
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database21DataSet = new WindowsFormsApp4.database21DataSet();
            this.парикмахерскиеУслугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.парикмахерские_услугиTableAdapter = new WindowsFormsApp4.database21DataSetTableAdapters.Парикмахерские_услугиTableAdapter();
            this.парикмахерскиеУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продолжительностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскиеУслугиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.парикмахерскиеУслугиDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.продолжительностьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.парикмахерскиеУслугиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(106, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // database21DataSet
            // 
            this.database21DataSet.DataSetName = "database21DataSet";
            this.database21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // парикмахерскиеУслугиBindingSource
            // 
            this.парикмахерскиеУслугиBindingSource.DataMember = "Парикмахерские услуги";
            this.парикмахерскиеУслугиBindingSource.DataSource = this.database21DataSet;
            // 
            // парикмахерские_услугиTableAdapter
            // 
            this.парикмахерские_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // парикмахерскиеУслугиDataGridViewTextBoxColumn
            // 
            this.парикмахерскиеУслугиDataGridViewTextBoxColumn.DataPropertyName = "Парикмахерские услуги";
            this.парикмахерскиеУслугиDataGridViewTextBoxColumn.HeaderText = "Парикмахерские услуги";
            this.парикмахерскиеУслугиDataGridViewTextBoxColumn.Name = "парикмахерскиеУслугиDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // продолжительностьDataGridViewTextBoxColumn
            // 
            this.продолжительностьDataGridViewTextBoxColumn.DataPropertyName = "Продолжительность";
            this.продолжительностьDataGridViewTextBoxColumn.HeaderText = "Продолжительность";
            this.продолжительностьDataGridViewTextBoxColumn.Name = "продолжительностьDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскиеУслугиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private database21DataSet database21DataSet;
        private System.Windows.Forms.BindingSource парикмахерскиеУслугиBindingSource;
        private database21DataSetTableAdapters.Парикмахерские_услугиTableAdapter парикмахерские_услугиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn парикмахерскиеУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продолжительностьDataGridViewTextBoxColumn;
    }
}