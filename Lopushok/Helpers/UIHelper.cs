using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lopushok
{
    public static class UIHelper
    {
        public static void AddPlaceholder(this TextBox tb, String text)
        {
            tb.ForeColor = Color.Gray;
            tb.Text = text;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == text)
                {
                    tb.ForeColor = Color.Black;
                    tb.Text = "";
                }
            };

            tb.Leave += (s, e) =>
            {
                if (tb.Text.Length == 0)
                {
                    tb.ForeColor = Color.Gray;
                    tb.Text = text;
                }
            };
        }
    }
}
