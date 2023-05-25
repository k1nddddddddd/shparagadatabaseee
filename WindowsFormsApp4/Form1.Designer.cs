namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.database21DataSet = new WindowsFormsApp4.database21DataSet();
            this.mAKEUPБРОВИBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAKE_UP__БРОВИTableAdapter = new WindowsFormsApp4.database21DataSetTableAdapters.MAKE_UP__БРОВИTableAdapter();
            this.mAKEUPБРОВИBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKEUPБРОВИBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKEUPБРОВИBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // mAKEUPБРОВИBindingSource1
            // 
            this.mAKEUPБРОВИBindingSource1.DataMember = "MAKE UP/ БРОВИ";
            this.mAKEUPБРОВИBindingSource1.DataSource = this.database21DataSet;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(146, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "MAKE UP/ БРОВИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Azure;
            this.button2.Location = new System.Drawing.Point(77, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ногтевой сервис";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Azure;
            this.button3.Location = new System.Drawing.Point(601, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Парикмахерская";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Azure;
            this.button4.Location = new System.Drawing.Point(647, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Расписание";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKEUPБРОВИBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKEUPБРОВИBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private database21DataSet database21DataSet;
        private System.Windows.Forms.BindingSource mAKEUPБРОВИBindingSource;
        private database21DataSetTableAdapters.MAKE_UP__БРОВИTableAdapter mAKE_UP__БРОВИTableAdapter;
        private System.Windows.Forms.BindingSource mAKEUPБРОВИBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

