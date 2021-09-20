using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckHexCode
{
    class HexCode : CheckHex
    {
        static int MAX_LENGTH = 6;

        string code;

        char[] hexArr = new char[MAX_LENGTH];

        public HexCode(string code)
        {
            this.code = code;
        }

        public void ValidateCode(string code)
        {
            for(int i = 0; i < MAX_LENGTH; i++)
            {
                hexArr[i] = code[i];
            }

            if (CheckForPoundKey(hexArr))
            {
                if (CheckIfDigit(hexArr))
                {
                    if (CheckForAlphabet(hexArr))
                    {
                        Console.WriteLine("This is a valid hex code!");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
