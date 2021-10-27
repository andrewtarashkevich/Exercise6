using System;

namespace ClassLibrary1
{
    public class Book
    {
        private string name;
        private string library;
        private int pages;
        public Book(string library,string name,int pages)
        {
            this.library = library;           
            this.name = name;
            this.pages = pages;                
        }
        public string Name 
        {
            get
            {
                return name;
            }
        }
        public string Library
        {
            get
            {
                return library;
            }
        }
        public int Pages
        {
            get
            {
                return pages;
            }
        }
    }       
}
