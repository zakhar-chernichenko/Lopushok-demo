using Lopushok.SQLServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lopushok
{
    public partial class MaterialTabelItem : UserControl
    {
        List<Material> _materials;
        public string Count
        {
            get { return count.Text; }
            set { count.Text = value; }
        }
        public (int, List<Material>, double) Data
        {
            get { return (materials.SelectedIndex, _materials, Convert.ToDouble(count.Text)); }
            set
            {
                _materials = value.Item2;
                materials.Items.Clear();
                materials.DataSource = _materials.Select(m => m.Title).ToList();
                materials.SelectedIndex = _materials.FindIndex(m => m.ID == value.Item1);
                count.Text = value.Item3.ToString();
            }
        }
        public MaterialTabelItem()
        {
            InitializeComponent();
            _materials = new List<Material>();
        }
    }
}
