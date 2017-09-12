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
        }
    }
}
