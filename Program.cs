using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLogical
{
    class TrianglePattern
    {
        static void main(String[] args)
        {
            int spc, len = 1, count;
            Console.WriteLine("Enter the row : ");
            count = Convert.ToInt32(Console.ReadLine());
            spc = count - 1;
            for (int i = 1; i <= spc; i++)
            {
                for (int r = 1; r <= spc; r++)
                {
                    Console.WriteLine(" ");
                }
                for (int s = 1; s <= len; s++)
                {
                    Console.WriteLine("*");
                }
                spc--;
                len = len + 2;
                Console.WriteLine();
            }
            Console.Readline();
        }
    }
}