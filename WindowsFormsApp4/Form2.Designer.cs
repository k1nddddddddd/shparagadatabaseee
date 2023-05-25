namespace WindowsFormsApp4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database21DataSet = new WindowsFormsApp4.database21DataSet();
            this.mAKEUPБРОВИBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAKE_UP__БРОВИTableAdapter = new WindowsFormsApp4.database21DataSetTableAdapters.MAKE_UP__БРОВИTableAdapter();
            this.mAKEUPБровиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продолжительностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKEUPБРОВИBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKEUPБровиDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.продолжительностьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mAKEUPБРОВИBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(117, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // database21DataSet
            // 
            this.database21DataSet.DataSetName = "database21DataSet";
            this.database21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAKEUPБРОВИBindingSource
            // 
            this.mAKEUPБРОВИBindingSource.DataMember = "MAKE UP/ БРОВИ";
            this.mAKEUPБРОВИBindingSource.DataSource = this.database21DataSet;
            // 
            // mAKE_UP__БРОВИTableAdapter
            // 
            this.mAKE_UP__БРОВИTableAdapter.ClearBeforeFill = true;
            // 
            // mAKEUPБровиDataGridViewTextBoxColumn
            // 
            this.mAKEUPБровиDataGridViewTextBoxColumn.DataPropertyName = "MAKE UP/ Брови";
            this.mAKEUPБровиDataGridViewTextBoxColumn.HeaderText = "MAKE UP/ Брови";
            this.mAKEUPБровиDataGridViewTextBoxColumn.Name = "mAKEUPБровиDataGridViewTextBoxColumn";
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKEUPБРОВИBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private database21DataSet database21DataSet;
        private System.Windows.Forms.BindingSource mAKEUPБРОВИBindingSource;
        private database21DataSetTableAdapters.MAKE_UP__БРОВИTableAdapter mAKE_UP__БРОВИTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKEUPБровиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продолжительностьDataGridViewTextBoxColumn;
    }
}