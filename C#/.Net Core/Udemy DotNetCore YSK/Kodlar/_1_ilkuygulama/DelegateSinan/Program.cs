using System;
using System.Runtime.InteropServices;

namespace DelegateSinan
{
    internal class Program
    {
        public delegate void DelegateSinanDelegate();
        static void Main(string[] args)
        {
            Console.WriteLine("Bir şey seç 1 = Elma , 2. Portakal");
            var sonuc = Console.ReadLine();
            if (sonuc == "1")
            {
                Calistir(ElmaEkle);
            }
            else
            {
                Calistir(PortakalEkle);

            }


            Console.ReadLine();
        }

        public static void Calistir(DelegateSinanDelegate d )
        {
            d.Invoke();
        }

        public static void ElmaEkle()
        {
            Console.WriteLine("Elma Eklendi ");
        }

        public static void PortakalEkle()
        {
            Console.WriteLine("Elma Eklendi ");
        }

    }
}
