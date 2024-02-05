using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lopushok
{
    public static class BackHelper
    {
        public static string GetImagePath(string imagePath, string nullImagePath = "\\img\\null.png")
        {
            var debug = "bin\\Debug";
            var release = "bin\\Release";

            return $"{Directory.GetCurrentDirectory().Replace(debug, "").Replace(release, "")}Images{(imagePath == "" || imagePath == null ? nullImagePath : imagePath)}";
        }

        public static string GetImagePathOFD(string nullImagePath = "\\img\\null.png")
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return "\\" + string.Join("\\", ofd.FileName.Split('\\').Reverse().Take(2).Reverse());
                }

                return nullImagePath;
            }
        }
    }
}
