using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckHexCode
{
    class CheckHex
    {
        public bool CheckForPoundKey(char[] code) 
        {
            if(code[0] != '#')
            {
                Console.WriteLine("All Hex codes must begin with a '#'!! ");
                return false;
            }
            return true;
        }
        public bool CheckIfDigit(char[] code) 
        {
            bool bAlpha = CheckForAlphabet(code);
            for(int i =1; i < code.Length; i++)
            {
                if (bAlpha == true && code[i] <= 9)
                {
                    Console.WriteLine("");
                    return true;
                }
            }
            return false;
        }
        public bool CheckForAlphabet(char[] code) 
        {
            bool bDigit = CheckIfDigit(code);
            for (int i = 1; i < code.Length; i++)
            {
                if ( bDigit == true && code[i] > 'F')
                {
                    Console.WriteLine("Only alphabets A - F is allowed!");
                    return false;
                }
            }
            return true;
        }
    }
}
