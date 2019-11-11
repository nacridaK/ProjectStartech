using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Startech
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string konum = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/Seri Port Veri Görüntüleme Yazılımı";
            if (!Directory.Exists(konum))
            {
                Directory.CreateDirectory(konum);
                MessageBox.Show("Bu programın ilk açılışı!");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
