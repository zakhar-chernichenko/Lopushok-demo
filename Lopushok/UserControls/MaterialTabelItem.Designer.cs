namespace Lopushok
{
    partial class MaterialTabelItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materials = new System.Windows.Forms.ComboBox();
            this.count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // materials
            // 
            this.materials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materials.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materials.FormattingEnabled = true;
            this.materials.Location = new System.Drawing.Point(3, 3);
            this.materials.Name = "materials";
            this.materials.Size = new System.Drawing.Size(716, 39);
            this.materials.TabIndex = 0;
            // 
            // count
            // 
            this.count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.count.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(725, 6);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(205, 36);
            this.count.TabIndex = 1;
            // 
            // materialTabelItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.count);
            this.Controls.Add(this.materials);
            this.Name = "materialTabelItem";
            this.Size = new System.Drawing.Size(935, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox materials;
        private System.Windows.Forms.TextBox count;
    }
}
