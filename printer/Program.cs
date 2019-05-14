using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printer
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows pr;

            Console.WriteLine("Pilih Printer :");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. Laserjet \n");

            Console.WriteLine("Nomor Printer [1..3]: ");
            int nomor = Convert.ToInt32(Console.ReadLine());

            if (nomor == 1)
                pr = new Epson();
            else if (nomor == 2)
                pr = new Canon();
            else
                pr = new Laserjet();

            pr.Show();
            pr.Print();

            Console.ReadKey();
        }
    }
}
