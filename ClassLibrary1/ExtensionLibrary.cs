using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public /*static*/ partial class Library
    {
        public void ShowThickest()
        {
            string max_name = "";
            int max_page = int.MinValue;
            foreach (Book b in booksArray)
            {
                if (b.Pages > max_page)
                {
                    max_page = b.Pages;
                    max_name = b.Name;
                }
            }
            Console.WriteLine("Самая тостая книга: {0}({1} стр.)", max_name, max_page);
        }

    }
}
