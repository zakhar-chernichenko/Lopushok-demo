using System;
using System.Collections.Generic;

namespace Lopushok
{
    public class PageHelper
    {
        public static int GetCurrentPage(string text)
        {
            var start = text.IndexOf('(') + 1;
            var length = text.IndexOf(')') - start;

            return Convert.ToInt32(text.Substring(start, length));
        }

        public static int GetLastPage(string text)
        {
            var end = text.Length;
            var start = text.LastIndexOf(' ') + 1;

            var res = "";
            for (int i = start; i < end; i++)
            {
                if (Char.IsDigit(text[i])) res += text[i];
            }

            return Convert.ToInt32(res);
        }

        public static string GetPagesView(int page, int count)
        {
            var s = new List<String>();

            for (int i = 1; i < count; i++)
            {
                if (i == page) s.Add($"({i})");
                else s.Add(i.ToString());
            }

            return String.Join(" ", s);
        }
    }
}
