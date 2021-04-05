using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareDekart
{
    class Program
    {
        static void Main(string[] args)
        {
            Answer a = new Answer("Чяго", 2);
            Answer b = new Answer("НиЧяго", 5);

            Console.WriteLine(a);
            Console.WriteLine(b);

            QuestDekart dec = new QuestDekart("Что будет если это произойдет");
            Console.WriteLine(dec);
            dec.Add(a);
            dec.Add(b);
            Console.WriteLine(dec);
            Console.WriteLine(dec.SumPoint());
        }
    }
}
