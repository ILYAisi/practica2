namespace practika
{
    partial class ListItem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductCost = new System.Windows.Forms.Label();
            this.ProductManifacture = new System.Windows.Forms.Label();
            this.ProductDecember = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InStore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(1076, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Осталось:";
            // 
            // ProductCost
            // 
            this.ProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProductCost.Location = new System.Drawing.Point(255, 128);
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.Size = new System.Drawing.Size(419, 26);
            this.ProductCost.TabIndex = 16;
            this.ProductCost.Text = "Цена";
            // 
            // ProductManifacture
            // 
            this.ProductManifacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProductManifacture.Location = new System.Drawing.Point(197, 91);
            this.ProductManifacture.Name = "ProductManifacture";
            this.ProductManifacture.Size = new System.Drawing.Size(419, 20);
            this.ProductManifacture.TabIndex = 15;
            this.ProductManifacture.Text = "Производитель";
            // 
            // ProductDecember
            // 
            this.ProductDecember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProductDecember.Location = new System.Drawing.Point(197, 51);
            this.ProductDecember.Name = "ProductDecember";
            this.ProductDecember.Size = new System.Drawing.Size(419, 23);
            this.ProductDecember.TabIndex = 14;
            this.ProductDecember.Text = "Описание товара";
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProductName.Location = new System.Drawing.Point(197, 16);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(419, 23);
            this.ProductName.TabIndex = 13;
            this.ProductName.Text = "Наименование товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(197, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Цена:";
            // 
            // InStore
            // 
            this.InStore.AutoSize = true;
            this.InStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InStore.Location = new System.Drawing.Point(837, 128);
            this.InStore.Name = "InStore";
            this.InStore.Size = new System.Drawing.Size(76, 20);
            this.InStore.TabIndex = 19;
            this.InStore.Text = "Наличие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(762, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Осталось:";
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Controls.Add(this.InStore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductCost);
            this.Controls.Add(this.ProductManifacture);
            this.Controls.Add(this.ProductDecember);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(1081, 160);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProductCost;
        private System.Windows.Forms.Label ProductManifacture;
        private System.Windows.Forms.Label ProductDecember;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InStore;
        private System.Windows.Forms.Label label3;
    }
}
