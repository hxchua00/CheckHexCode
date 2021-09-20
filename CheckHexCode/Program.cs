using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckHexCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your hex code: ");
            string hexCode = Console.ReadLine();

            HexCode code = new HexCode(hexCode);
            code.ValidateCode(hexCode);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
