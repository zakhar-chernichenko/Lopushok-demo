namespace Lopushok.Forms
{
    partial class Edit
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
            System.Windows.Forms.Label articleNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label minCostForAgentLabel;
            System.Windows.Forms.Label productionPersonCountLabel;
            System.Windows.Forms.Label productionWorkshopNumberLabel;
            System.Windows.Forms.Label productTypeIDLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.articleNumberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.minCostForAgentTextBox = new System.Windows.Forms.TextBox();
            this.productionPersonCountTextBox = new System.Windows.Forms.TextBox();
            this.productionWorkshopNumberTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.productType = new System.Windows.Forms.ComboBox();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.productMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTable = new System.Windows.Forms.Panel();
            articleNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            minCostForAgentLabel = new System.Windows.Forms.Label();
            productionPersonCountLabel = new System.Windows.Forms.Label();
            productionWorkshopNumberLabel = new System.Windows.Forms.Label();
            productTypeIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // articleNumberLabel
            // 
            articleNumberLabel.AutoSize = true;
            articleNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            articleNumberLabel.Location = new System.Drawing.Point(356, 57);
            articleNumberLabel.Name = "articleNumberLabel";
            articleNumberLabel.Size = new System.Drawing.Size(83, 20);
            articleNumberLabel.TabIndex = 1;
            articleNumberLabel.Text = "Артикул:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(22, 212);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(96, 20);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Описание:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            imageLabel.Location = new System.Drawing.Point(22, 29);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(126, 20);
            imageLabel.TabIndex = 7;
            imageLabel.Text = "Изображение:";
            // 
            // minCostForAgentLabel
            // 
            minCostForAgentLabel.AutoSize = true;
            minCostForAgentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            minCostForAgentLabel.Location = new System.Drawing.Point(356, 117);
            minCostForAgentLabel.Name = "minCostForAgentLabel";
            minCostForAgentLabel.Size = new System.Drawing.Size(247, 20);
            minCostForAgentLabel.TabIndex = 9;
            minCostForAgentLabel.Text = "Мин. стоимость для агента:";
            // 
            // productionPersonCountLabel
            // 
            productionPersonCountLabel.AutoSize = true;
            productionPersonCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productionPersonCountLabel.Location = new System.Drawing.Point(356, 147);
            productionPersonCountLabel.Name = "productionPersonCountLabel";
            productionPersonCountLabel.Size = new System.Drawing.Size(145, 20);
            productionPersonCountLabel.TabIndex = 11;
            productionPersonCountLabel.Text = "Кол-во человек:";
            // 
            // productionWorkshopNumberLabel
            // 
            productionWorkshopNumberLabel.AutoSize = true;
            productionWorkshopNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productionWorkshopNumberLabel.Location = new System.Drawing.Point(356, 177);
            productionWorkshopNumberLabel.Name = "productionWorkshopNumberLabel";
            productionWorkshopNumberLabel.Size = new System.Drawing.Size(190, 20);
            productionWorkshopNumberLabel.TabIndex = 13;
            productionWorkshopNumberLabel.Text = "Кол-во рабочих мест:";
            // 
            // productTypeIDLabel
            // 
            productTypeIDLabel.AutoSize = true;
            productTypeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productTypeIDLabel.Location = new System.Drawing.Point(356, 87);
            productTypeIDLabel.Name = "productTypeIDLabel";
            productTypeIDLabel.Size = new System.Drawing.Size(128, 20);
            productTypeIDLabel.TabIndex = 15;
            productTypeIDLabel.Text = "Тип продукта:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(356, 27);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(96, 20);
            titleLabel.TabIndex = 17;
            titleLabel.Text = "Название:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(22, 295);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 20);
            label1.TabIndex = 23;
            label1.Text = "Материалы:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(109, 324);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 20);
            label2.TabIndex = 26;
            label2.Text = "Материал";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(799, 324);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(109, 20);
            label3.TabIndex = 27;
            label3.Text = "Количество";
            // 
            // articleNumberTextBox
            // 
            this.articleNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.articleNumberTextBox.Location = new System.Drawing.Point(625, 51);
            this.articleNumberTextBox.Name = "articleNumberTextBox";
            this.articleNumberTextBox.Size = new System.Drawing.Size(364, 27);
            this.articleNumberTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(145, 212);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(844, 71);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // minCostForAgentTextBox
            // 
            this.minCostForAgentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minCostForAgentTextBox.Location = new System.Drawing.Point(625, 110);
            this.minCostForAgentTextBox.Name = "minCostForAgentTextBox";
            this.minCostForAgentTextBox.Size = new System.Drawing.Size(364, 27);
            this.minCostForAgentTextBox.TabIndex = 10;
            // 
            // productionPersonCountTextBox
            // 
            this.productionPersonCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionPersonCountTextBox.Location = new System.Drawing.Point(625, 139);
            this.productionPersonCountTextBox.Name = "productionPersonCountTextBox";
            this.productionPersonCountTextBox.Size = new System.Drawing.Size(364, 27);
            this.productionPersonCountTextBox.TabIndex = 12;
            // 
            // productionWorkshopNumberTextBox
            // 
            this.productionWorkshopNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionWorkshopNumberTextBox.Location = new System.Drawing.Point(625, 168);
            this.productionWorkshopNumberTextBox.Name = "productionWorkshopNumberTextBox";
            this.productionWorkshopNumberTextBox.Size = new System.Drawing.Size(364, 27);
            this.productionWorkshopNumberTextBox.TabIndex = 14;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(625, 22);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(364, 27);
            this.titleTextBox.TabIndex = 18;
            // 
            // productType
            // 
            this.productType.DataSource = this.productTypeBindingSource;
            this.productType.DisplayMember = "Title";
            this.productType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productType.FormattingEnabled = true;
            this.productType.Location = new System.Drawing.Point(625, 80);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(364, 28);
            this.productType.TabIndex = 19;
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(Lopushok.SQLServer.ProductType);
            // 
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Location = new System.Drawing.Point(25, 60);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(249, 137);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 20;
            this.imageBox.TabStop = false;
            this.imageBox.Click += new System.EventHandler(this.imageBox_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(68, 556);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(167, 48);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = " Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(781, 559);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(167, 45);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // productMaterialBindingSource
            // 
            this.productMaterialBindingSource.DataSource = typeof(Lopushok.SQLServer.ProductMaterial);
            // 
            // materialTable
            // 
            this.materialTable.AutoScroll = true;
            this.materialTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.materialTable.Location = new System.Drawing.Point(12, 347);
            this.materialTable.Name = "materialTable";
            this.materialTable.Size = new System.Drawing.Size(977, 203);
            this.materialTable.TabIndex = 25;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 630);
            this.Controls.Add(label3);
            this.Controls.Add(this.materialTable);
            this.Controls.Add(label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.productType);
            this.Controls.Add(articleNumberLabel);
            this.Controls.Add(this.articleNumberTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(minCostForAgentLabel);
            this.Controls.Add(this.minCostForAgentTextBox);
            this.Controls.Add(productionPersonCountLabel);
            this.Controls.Add(this.productionPersonCountTextBox);
            this.Controls.Add(productionWorkshopNumberLabel);
            this.Controls.Add(this.productionWorkshopNumberTextBox);
            this.Controls.Add(productTypeIDLabel);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Name = "Edit";
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox articleNumberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox minCostForAgentTextBox;
        private System.Windows.Forms.TextBox productionPersonCountTextBox;
        private System.Windows.Forms.TextBox productionWorkshopNumberTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox productType;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private System.Windows.Forms.BindingSource productMaterialBindingSource;
        private System.Windows.Forms.Panel materialTable;
    }
}