using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionWithoutSpecialCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the value: ");
            string a = Console.ReadLine();
            string encryp= CryptoEngine.ConvertStringToHex(a);
            string decryp = CryptoEngine.ConvertHexToString(encryp);
            Console.WriteLine(encryp);
            Console.WriteLine(decryp);
        }
    }
}
