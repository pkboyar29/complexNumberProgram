using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbersProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ComplNum cmp1 = new ComplNum(42, 56);
                Console.WriteLine(cmp1);
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
