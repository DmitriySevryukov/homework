using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8._1_4
{
    class Program
    {
        struct book
        {
            public string title;
            public string author;
            public int pageCount;
            public int id;
        }
        static void Main(string[] args)
        {
            book[] books = new book[4];

            Console.Write("Enter title of the first book: ");
            books[0].title = Console.ReadLine();
            Console.Write("Enter author of the first book: ");
            books[0].author = Console.ReadLine();
            Console.Write("Enter number of pages of the first book: ");
            books[0].pageCount = int.Parse(Console.ReadLine());
            Console.Write("Enter id of the first book: ");
            books[0].id = int.Parse(Console.ReadLine());

            Console.Write("Enter title of the second book: ");
            books[1].title = Console.ReadLine();
            Console.Write("Enter author of the second book: ");
            books[1].author = Console.ReadLine();
            Console.Write("Enter number of pages of the second book: ");
            books[1].pageCount = int.Parse(Console.ReadLine());
            Console.Write("Enter id of the second book: ");
            books[1].id = int.Parse(Console.ReadLine());

            Console.Write("Enter title of the third book: ");
            books[2].title = Console.ReadLine();
            Console.Write("Enter author of the third book: ");
            books[2].author = Console.ReadLine();
            Console.Write("Enter number of pages of the third book: ");
            books[2].pageCount = int.Parse(Console.ReadLine());
            Console.Write("Enter id of the third book: ");
            books[2].id = int.Parse(Console.ReadLine());

            Console.Write("Enter title of the fourth book: ");
            books[3].title = Console.ReadLine();
            Console.Write("Enter author of the fourth book: ");
            books[3].author = Console.ReadLine();
            Console.Write("Enter number of pages of the fourth book: ");
            books[3].pageCount = int.Parse(Console.ReadLine());
            Console.Write("Enter id of the fourth book: ");
            books[3].id = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int x, y;
            Console.SetCursorPosition(20, 0);
            Console.Write("id");
        }
    }
}
