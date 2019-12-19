using System;
using System.Drawing;
using System.Windows.Forms;
namespace ManagementCoffeShop.Core.Utilities
{
    public class saveImage
    {
        private static saveImage instance;

        public static saveImage Instance
        {
            get
            {
                if (instance == null) return instance = new saveImage();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public string saveImagePath(string files)
        {
            try
            {
                string[] name = files.Split('\\');
                string[] namShort = name[name.Length - 1].Split('.');
                Image image = Image.FromFile(files);
                image.Save(Application.StartupPath + "\\Images\\" + namShort[0] + ".png");
                return namShort[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return "";
        }
    }
}
