using System;
using System.Runtime.Intrinsics.Arm;

namespace Delegateler
{

    internal class Program
    {
        public delegate void MyDelegate();

        static void Main(string[] args)
        {
            MyDelegate d = new MyDelegate(Topla);
            
            d.Invoke();
        
            Console.WriteLine("-------------------------------------");
            d += Cikar;
            d.Invoke();

            Console.ReadLine ();
        }

        public static void Topla()
        {
            Console.WriteLine("Topla");
        }

        public static void Cikar()
        {
            Console.WriteLine("Cikar");
        }
    }
}
