namespace Lopushok
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.filter = new System.Windows.Forms.ComboBox();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sort = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.TextBox();
            this.displayProducts = new System.Windows.Forms.Panel();
            this.pageNext = new System.Windows.Forms.Label();
            this.pageCounter = new System.Windows.Forms.Label();
            this.PageBack = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.filter.DataSource = this.productTypeBindingSource;
            this.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filter.FormattingEnabled = true;
            this.filter.Location = new System.Drawing.Point(995, 43);
            this.filter.Margin = new System.Windows.Forms.Padding(4);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(284, 53);
            this.filter.TabIndex = 1;
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // sort
            // 
            this.sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sort.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sort.FormattingEnabled = true;
            this.sort.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.sort.Location = new System.Drawing.Point(673, 43);
            this.sort.Margin = new System.Windows.Forms.Padding(4);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(284, 53);
            this.sort.TabIndex = 2;
            this.sort.SelectedIndexChanged += new System.EventHandler(this.sort_SelectedIndexChanged);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.search.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(16, 46);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(619, 48);
            this.search.TabIndex = 10;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // displayProducts
            // 
            this.displayProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayProducts.AutoScroll = true;
            this.displayProducts.Location = new System.Drawing.Point(0, 139);
            this.displayProducts.Name = "displayProducts";
            this.displayProducts.Size = new System.Drawing.Size(1296, 503);
            this.displayProducts.TabIndex = 12;
            // 
            // pageNext
            // 
            this.pageNext.AutoSize = true;
            this.pageNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.pageNext.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageNext.Location = new System.Drawing.Point(1010, 0);
            this.pageNext.Name = "pageNext";
            this.pageNext.Size = new System.Drawing.Size(51, 27);
            this.pageNext.TabIndex = 1;
            this.pageNext.Text = " > ";
            this.pageNext.Click += new System.EventHandler(this.pageNext_Click);
            // 
            // pageCounter
            // 
            this.pageCounter.AutoSize = true;
            this.pageCounter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pageCounter.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageCounter.Location = new System.Drawing.Point(985, 0);
            this.pageCounter.Name = "pageCounter";
            this.pageCounter.Size = new System.Drawing.Size(25, 27);
            this.pageCounter.TabIndex = 2;
            this.pageCounter.Text = "1";
            // 
            // PageBack
            // 
            this.PageBack.AutoSize = true;
            this.PageBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.PageBack.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageBack.Location = new System.Drawing.Point(934, 0);
            this.PageBack.Name = "PageBack";
            this.PageBack.Size = new System.Drawing.Size(51, 27);
            this.PageBack.TabIndex = 3;
            this.PageBack.Text = " < ";
            this.PageBack.Click += new System.EventHandler(this.pageBack_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.PageBack);
            this.panel1.Controls.Add(this.pageCounter);
            this.panel1.Controls.Add(this.pageNext);
            this.panel1.Location = new System.Drawing.Point(235, 648);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 52);
            this.panel1.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Font = new System.Drawing.Font("Gabriola", 14.25F);
            this.addButton.Location = new System.Drawing.Point(0, 648);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(229, 52);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Добавить товар";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1296, 700);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayProducts);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Лопушок";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.ComboBox sort;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private System.Windows.Forms.Panel displayProducts;
        private System.Windows.Forms.Label pageNext;
        private System.Windows.Forms.Label pageCounter;
        private System.Windows.Forms.Label PageBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addButton;
    }
}

