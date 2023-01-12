//імпортуєм типи данних з одного простір імен (using) 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

//створюємо простір імен University
namespace University
{
    internal static class Program  //головний статичний класс Program
    {
        /// <summary>
        /// Головна точка входу в додаток.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); //запуск відображення форми
        }
    }
}
