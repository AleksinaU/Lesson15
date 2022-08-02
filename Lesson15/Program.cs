using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression(5,10);
            arithProgression.SetStart(1);
            Console.Write("Арифметическая прогрессия: ");
            Console.Write("1 ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", arithProgression.GetNext());
                
            }
            Console.WriteLine();
            GeomProgression geomProgression = new GeomProgression(3, 5);
            geomProgression.SetStart(2);
            Console.Write("Геометрическая прогрессия: ");
            Console.Write("2 ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write("{0} ", geomProgression.GetNext());
            }
            Console.ReadKey();
        }
    }
}
