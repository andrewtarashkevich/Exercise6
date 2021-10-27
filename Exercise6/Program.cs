using System;
using ClassLibrary1;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Добавляю книги в общую базу библиотек
            Library baseLibrary = new Library(3);
            baseLibrary.AddBook(0,"Центральная","Война и мир",562);
            baseLibrary.AddBook(1,"Городская", "Мертвые души", 348);
            baseLibrary.AddBook(2,"Пушкинская", "Бесы", 602);

            //Ищу книгу по индексу
            baseLibrary.InfoByIndex(1);

            //Ищу книгу по названию
            Console.Write("Введите имя книги:");
            baseLibrary.InfoByName(Console.ReadLine());

            //Ищу самую толстую(не понял как реализовать через метод расширения)
            baseLibrary.ShowThickest();
        }
    }
}
