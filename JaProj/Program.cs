using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JaProj
{
    unsafe class Program
    {
        [DllImport(@"C:\Users\artur\source\repos\JaProj\x64\Debug\JAAsm.dll")]
        static unsafe extern int MyProc1(int a, int b, int c, int* p);
        static unsafe void Main(string[] args)
        {
            int x = -2000000000, y = -2000000000, z = -15, p = -45;

            int[] tab = { 1, 2, 3, 4, 5 };
            //z = tab[0];
            fixed (int* d = tab)
            {

                int retVal = MyProc1(x, y, z, d);
                Console.Write("Moja pierwsza wartość obliczona w asm to:");
                Console.WriteLine(retVal);
                Console.ReadLine();
            }

        }
    }
}
