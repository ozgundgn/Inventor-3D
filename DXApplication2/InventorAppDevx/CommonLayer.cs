using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorAppDevx
{
   public static class CommonLayer
    {
        public static string DirectoryPath = FilePath();
        public  static string FilePath()
        {
            TextReader redaer = new StreamReader("Anadizin.txt");
            return redaer.ReadToEnd();
        }
    }
}
