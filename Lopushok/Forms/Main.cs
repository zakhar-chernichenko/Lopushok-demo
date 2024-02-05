using System;
using System.Linq;
using System.Windows.Forms;

namespace Lopushok
{
    public partial class Main : Form
    {
        private readonly string placeholder = "Введите для поиска";
        private readonly string allTypes = "Все виды";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {



            search.AddPlaceholder(placeholder);

            var list = DBHelper.db.ProductType.Select(pt => pt.Title).ToList();
            list.Insert(0, allTypes);
            productTypeBindingSource.DataSource = list;

            sort.SelectedIndex = 0;

            ViewControlData();
        }

        public void ViewControlData(int page = 1, int count = 20)
        {
            // GET PRODUCTS
            var list = DBHelper.db.Product.ToList();

            // SEARCH TIME
            if (search.Text != placeholder && search.Text.Trim() != "")
            {
                list = list.Where(p => (p.Title + p.Description).ToLower().Contains(search.Text.ToLower())).ToList();
            }

            // SORT TIME
            if (sort.SelectedIndex == 0)
            {
                list = list.OrderBy(p => p.Title)
                            .OrderBy(p => p.ProductionWorkshopNumber)
                            .OrderBy(p => p.MinCostForAgent)
                            .ToList();
            }
            else
            {
                list = list.OrderByDescending(p => p.Title)
                            .OrderByDescending(p => p.ProductionWorkshopNumber)
                            .OrderByDescending(p => p.MinCostForAgent)
                            .ToList();
            }

            // FILTER TIME
            if (filter.SelectedIndex != 0)
            {
                list = list.Where(p => p.ProductTypeID == filter.SelectedIndex).ToList();
            }

            // PAGE TIME
            var offset = 1;
            if (list.Count % count != 0)
                offset++;
            pageCounter.Text = PageHelper.GetPagesView(page, list.Count / count + offset);

            list = list.Skip((page - 1) * count).Take(count).ToList();
            /* 
              if (list.Count < page * count)
                list = list.GetRange((page - 1) * count, list.Count - (page - 1) * count);
              else
                list = list.GetRange((page - 1) * count, count);
            */

            // FILL DATA
            displayProducts.Controls.Clear();
            foreach (var product in list)
            {
                displayProducts.Controls.Add(new ProductView(product, ViewControlData) { Dock = DockStyle.Top });
            }

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            ViewControlData();
        }

        private void sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewControlData();
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewControlData();
        }
        private void pageBack_Click(object sender, EventArgs e)
        {
            var page = PageHelper.GetCurrentPage(pageCounter.Text);
            if (page > 1)
                ViewControlData(page - 1);
        }

        private void pageNext_Click(object sender, EventArgs e)
        {
            var page = PageHelper.GetCurrentPage(pageCounter.Text);
            if (page < PageHelper.GetLastPage(pageCounter.Text))
                ViewControlData(page + 1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Почти такое же как и окно редактирования.\n\nP.S. А чтобы редактировать товар, 2 раза кликни по плитке с товаром :)");
        }
    }
}
