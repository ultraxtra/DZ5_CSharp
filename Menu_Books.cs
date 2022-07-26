using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DZ5_CSharp
{
    internal class Menu_Books
    {
        private ListOfBooks? listOfBooks;

        public Menu_Books()
        {
            this.listOfBooks = new ListOfBooks();
        }
        public void MenuItem1()
        {
            Book book = new Book();
            book = book.CreateBook();
            listOfBooks += book;
        }

        public void MenuItem2()
        {
            Book book = new Book();
            Write("Input removing num: ");
            int number = Convert.ToInt32(ReadLine());
            if(number > 0 && number <= listOfBooks.Length())
            {
                book = listOfBooks[number - 1];
                listOfBooks = listOfBooks - book;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void MenuItem3()
        {
            string? Title = null;
            Title = ReadLine();
            if (listOfBooks.IsExist(Title))
            {
                Write("Book exists!");
                Thread.Sleep(1000);
            }

            else
            {
                Write("Book is not found!");
            Thread.Sleep(1000);
            }
        }

        public void PrintMenu()
        {
            WriteLine("\t\t\tMenu:");
            WriteLine("\t\t\t1-Add Book");
            WriteLine("\t\t\t2-Remove book");
            WriteLine("\t\t\t3-Check avaliabilty");
            WriteLine("\t\t\t4-Exit");
        }

        public void PrintList()
        {
            listOfBooks.PrintList();
        }
    }
}

