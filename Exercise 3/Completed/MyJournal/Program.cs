using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            Console.WriteLine(myJournal.JournalMessage);

            int choice;
            do
            {
                Console.WriteLine("\nMenu: ");
                Console.WriteLine("1) Unlock");
                Console.WriteLine("2) Create entry");
                Console.WriteLine("3) Read entry");
                Console.WriteLine("4) Lock");
                Console.WriteLine("5) Quit");
                Console.WriteLine("----------------------------------------------------\n");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                }
            } while (choice != 5);
        }
    }
}
