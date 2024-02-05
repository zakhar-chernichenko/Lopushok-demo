using Lopushok.Forms;
using Lopushok.SQLServer;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lopushok
{

    public delegate void UpdateProducts(int page = 1, int count = 20);
    public partial class ProductView : UserControl
    {
        private UpdateProducts _updateProducts;
        private Product _product;
        public ProductView(Product product, UpdateProducts updateProducts)
        {
            InitializeComponent();

            _updateProducts = updateProducts;
            _product = product;
        }

        private void ProductView_DoubleClick(object sender, EventArgs e)
        {
            if (new Edit(_updateProducts).fillData(_product).ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Данные успешно сохранены!");
                _updateProducts();
            }
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            image.Image = Image.FromFile(BackHelper.GetImagePath(_product.Image));

            typeAndName.Text = $"{_product.ProductType.Title} | {_product.Title}";
            article.Text = _product.ArticleNumber;

            var materialList = DBHelper.db.ProductMaterial.Where(pm => pm.ProductID == _product.ID).ToList();

            materials.Text = $"Материалы: {String.Join(", ", materialList.Select(pm => pm.Material.Title))}";
            cost.Text = materialList.Select(pm => pm.Material.Cost).Sum().ToString();
        }
    }
}
