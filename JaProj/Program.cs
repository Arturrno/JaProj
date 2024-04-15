using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JaProj
{
    internal class Program
    {
        [DllImport(@"C:\Users\artur\source\repos\JaProj\x64\Debug\JAAsm.dll")]
        static extern int MyProc1(int a, int b);
        static void Main(string[] args)
        {
            int x = 5, y = 3;
            int retVal = MyProc1(x, y);
            Console.Write("Moja pierwsza wartosc obliczona w asm to: ");
            Console.WriteLine(retVal);
            Console.ReadLine();
        }
    }
}
