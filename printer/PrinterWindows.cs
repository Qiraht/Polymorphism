using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printer
{
    public class PrinterWindows
    {
      

        public virtual void Show()
        {
            Console.WriteLine("Anda sedang Menggunakan Printer");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printer sedang mencetak");
        }
    }
}
