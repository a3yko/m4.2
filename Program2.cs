using System;
using BookCase;

namespace M4._2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Instructions:");
            String[] inst = Console.ReadLine().Split(' ');
            Book[] shelf = new Book[Int32.Parse(inst[0])];

            for(int i = 0; i < Int32.Parse(inst[0]); i++)
            {
                Console.WriteLine("Please Enter Title:");
                String title = Console.ReadLine();
                Console.WriteLine("Please Enter Author:");
                String author = Console.ReadLine();
                Console.WriteLine("Please Enter Price:");
                double price = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter ISBN:");
                String isbn = Console.ReadLine();

                Console.Clear();

                Book one = new Book(title, author, price, isbn);
                shelf[i] = one;
            }
            if(Int32.Parse(inst[1]) == 1)
            {
                Book temp;
                for (int j = 0; j <= shelf.Length - 2; j++)
                {
                    for (int i = 0; i <= shelf.Length - 2; i++)
                    {
                        if (shelf[i].getPrice() > shelf[i + 1].getPrice())
                        {
                            temp = shelf[i + 1];
                            shelf[i + 1] = shelf[i];
                            shelf[i] = temp;
                        }
                    }
                }

                for(int i = 0; i < shelf.Length; i++)
                {
                    Console.WriteLine(shelf[i].printInformation());
                }
            }
        }
    }
}
