using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public partial class Library
    {
        private Book[] booksArray;
        public Library(int size)
        {
            booksArray = new Book[size];
        }
        public void AddBook(int index, string library, string name, int pages)
        {
            booksArray[index] = new Book(library, name, pages);
        }
        public void InfoByIndex(int index)
        {
            foreach (Book i in booksArray)
            {
                if (i == booksArray[index])
                    Console.WriteLine("Книга: {0}({1}стр.) находится в библиотеке - {2}", i.Name, i.Pages, i.Library);
            }
        }
        public void InfoByName(string Name)
        {
            Book searchBook = null;
            foreach (Book i in booksArray)
            {
                if (i.Name == Name)
                    searchBook = i;
            }
            if (searchBook != null)
                Console.WriteLine("Книга: {0}({1}стр.) находится в библиотеке - {2}", searchBook.Name, searchBook.Pages, searchBook.Library);
            else
                Console.WriteLine("Книга не найдена");
        }
        
    }
}
