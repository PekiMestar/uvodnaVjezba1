using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uvodna_vježba___varijable__ispis_podataka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;
            a = 100;
            b = 3;
            x = a / b;
            y = a % b;

            Console.WriteLine(a + " dijeljeno sa " + b + " je " + x + " , a ostatak je " + y);
            Console.ReadKey();
        }
    }
}
