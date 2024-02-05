using Lopushok.SQLServer;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lopushok.Forms
{
    public partial class Edit : Form
    {
        private UpdateProducts _updateProducts;
        private string _imagePath;
        private int _id;
        public Edit(UpdateProducts updateProducts)
        {
            InitializeComponent();
            _updateProducts = updateProducts;
        }

        public Edit fillData(Product product)
        {
            _id = product.ID;
            titleTextBox.Text = product.Title;
            articleNumberTextBox.Text = product.ArticleNumber;
            minCostForAgentTextBox.Text = product.MinCostForAgent.ToString();
            productionPersonCountTextBox.Text = product.ProductionPersonCount.ToString();
            productionWorkshopNumberTextBox.Text = product.ProductionWorkshopNumber.ToString();
            descriptionTextBox.Text = product.Description;

            _imagePath = product.Image;
            imageBox.Image = Image.FromFile(BackHelper.GetImagePath(product.Image));

            productTypeBindingSource.DataSource = DBHelper.db.ProductType.ToList();
            productType.SelectedIndex = (int)product.ProductTypeID - 1;

            var materialsFor = DBHelper.db.ProductMaterial.Where(pm => pm.ProductID == product.ID).ToList();
            var materials = DBHelper.db.Material.ToList();

            foreach (var m in materialsFor)
            {
                materialTable.Controls.Add(new MaterialTabelItem
                {
                    Dock = DockStyle.Top,
                    Count = m.Count.ToString(),
                    Data = (m.MaterialID, materials, (double)m.Count)
                });
            }

            return this;
        }

        private void imageBox_Click(object sender, EventArgs e)
        {
            _imagePath = BackHelper.GetImagePathOFD();
            imageBox.Image = Image.FromFile(BackHelper.GetImagePath(_imagePath));
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DBHelper.db.Product.Remove(DBHelper.db.Product.ToList().Find(p => p.ID == _id));

            DBHelper.db.SaveChanges();
            MessageBox.Show($"Продукт {titleTextBox.Text} успешно удален!");
            this.Close();

            _updateProducts();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(titleTextBox.Text) ||
                string.IsNullOrEmpty(articleNumberTextBox.Text) ||
                string.IsNullOrEmpty(minCostForAgentTextBox.Text) ||
                string.IsNullOrEmpty(productionPersonCountTextBox.Text) ||
                string.IsNullOrEmpty(productionWorkshopNumberTextBox.Text)
            )
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            try
            {
                var product = DBHelper.db.Product.Single(p => p.ID == _id);
                product.Title = titleTextBox.Text;
                product.ArticleNumber = articleNumberTextBox.Text;
                product.MinCostForAgent = Convert.ToDecimal(minCostForAgentTextBox.Text);
                product.ProductionPersonCount = Convert.ToInt32(productionPersonCountTextBox.Text);
                product.ProductionWorkshopNumber = Convert.ToInt32(productionWorkshopNumberTextBox.Text);
                product.Description = descriptionTextBox.Text;
                product.ProductTypeID = productType.SelectedIndex + 1;

                product.Image = _imagePath;

                DBHelper.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show($"Продукт {titleTextBox.Text} успешно обновлен!");
            this.Close();

            _updateProducts();
        }
    }
}
