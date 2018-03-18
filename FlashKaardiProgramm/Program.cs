using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FlashKaardiProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kus on path, mis sisaldab pilte?");
            string path = Console.ReadLine();

            FailiAvaja failiAvaja = new FailiAvaja();
            failiAvaja.Start(path);

            Console.ReadLine();
        }
    }
}
