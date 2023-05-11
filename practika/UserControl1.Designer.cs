namespace practika
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameUon = new System.Windows.Forms.Label();
            this.Description12 = new System.Windows.Forms.Label();
            this.Manufacturer1 = new System.Windows.Forms.Label();
            this.Cost1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameUon
            // 
            this.NameUon.AutoSize = true;
            this.NameUon.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameUon.Location = new System.Drawing.Point(295, 13);
            this.NameUon.Name = "NameUon";
            this.NameUon.Size = new System.Drawing.Size(192, 29);
            this.NameUon.TabIndex = 1;
            this.NameUon.Text = "Название товара";
            this.NameUon.Click += new System.EventHandler(this.label1_Click);
            // 
            // Description12
            // 
            this.Description12.AutoSize = true;
            this.Description12.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description12.Location = new System.Drawing.Point(296, 50);
            this.Description12.Name = "Description12";
            this.Description12.Size = new System.Drawing.Size(104, 27);
            this.Description12.TabIndex = 2;
            this.Description12.Text = "Описание";
            // 
            // Manufacturer1
            // 
            this.Manufacturer1.AutoSize = true;
            this.Manufacturer1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Manufacturer1.Location = new System.Drawing.Point(301, 88);
            this.Manufacturer1.Name = "Manufacturer1";
            this.Manufacturer1.Size = new System.Drawing.Size(126, 22);
            this.Manufacturer1.TabIndex = 3;
            this.Manufacturer1.Text = "Производитель";
            // 
            // Cost1
            // 
            this.Cost1.AutoSize = true;
            this.Cost1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cost1.Location = new System.Drawing.Point(304, 123);
            this.Cost1.Name = "Cost1";
            this.Cost1.Size = new System.Drawing.Size(48, 23);
            this.Cost1.TabIndex = 4;
            this.Cost1.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(629, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Наличие на складе";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cost1);
            this.Controls.Add(this.Manufacturer1);
            this.Controls.Add(this.Description12);
            this.Controls.Add(this.NameUon);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(853, 163);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameUon;
        private System.Windows.Forms.Label Description12;
        private System.Windows.Forms.Label Manufacturer1;
        private System.Windows.Forms.Label Cost1;
        private System.Windows.Forms.Label label5;
    }
}
