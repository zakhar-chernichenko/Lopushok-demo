namespace Lopushok
{
    partial class ProductView
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
            this.image = new System.Windows.Forms.PictureBox();
            this.typeAndName = new System.Windows.Forms.Label();
            this.article = new System.Windows.Forms.Label();
            this.materials = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(31, 27);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(219, 152);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // typeAndName
            // 
            this.typeAndName.AutoSize = true;
            this.typeAndName.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeAndName.Location = new System.Drawing.Point(273, 19);
            this.typeAndName.Name = "typeAndName";
            this.typeAndName.Size = new System.Drawing.Size(172, 55);
            this.typeAndName.TabIndex = 1;
            this.typeAndName.Text = "Тип и название";
            // 
            // article
            // 
            this.article.AutoSize = true;
            this.article.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.article.Location = new System.Drawing.Point(275, 66);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(86, 42);
            this.article.TabIndex = 2;
            this.article.Text = "Артикул";
            // 
            // materials
            // 
            this.materials.AutoSize = true;
            this.materials.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materials.Location = new System.Drawing.Point(275, 103);
            this.materials.Name = "materials";
            this.materials.Size = new System.Drawing.Size(112, 42);
            this.materials.TabIndex = 3;
            this.materials.Text = "Материалы:";
            // 
            // cost
            // 
            this.cost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost.Location = new System.Drawing.Point(800, 27);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(55, 42);
            this.cost.TabIndex = 4;
            this.cost.Text = "label1";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cost);
            this.Controls.Add(this.materials);
            this.Controls.Add(this.article);
            this.Controls.Add(this.typeAndName);
            this.Controls.Add(this.image);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(921, 222);
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.DoubleClick += new System.EventHandler(this.ProductView_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label typeAndName;
        private System.Windows.Forms.Label article;
        private System.Windows.Forms.Label materials;
        private System.Windows.Forms.Label cost;
    }
}
