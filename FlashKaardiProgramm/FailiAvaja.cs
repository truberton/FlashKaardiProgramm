using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace FlashKaardiProgramm
{
    class FailiAvaja
    {
        public void Start(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] failiNimed = dir.GetFiles();
            string[] failid = Directory.GetFiles(path);

            while (true)
            {
                Random random1 = new Random();
                int randomIndex = random1.Next(0, failid.Length - 1);
                Random random2 = new Random();
                int RandomName = random2.Next(100, 500000);

                string ext = Path.GetExtension(failid[randomIndex]);
                File.Copy(failid[randomIndex], Path.Combine(path, Convert.ToString(RandomName) + ext));
                Process.Start(Path.Combine(path, Convert.ToString(RandomName) + ext));

                while (true)
                {
                    Console.WriteLine("Millega on tegemist?");
                    string vastus = Console.ReadLine();

                    if (vastus.ToLower() == Path.GetFileNameWithoutExtension(failid[randomIndex]).ToLower() || vastus.ToLower() == "skip")
                    {
                        Console.WriteLine("Õige");
                        Thread.Sleep(500);
                        File.Delete(Path.Combine(path, Convert.ToString(RandomName) + ext));
                        break;
                    }
                    else if (string.IsNullOrWhiteSpace(vastus))
                    {
                        File.Delete(Path.Combine(path, Convert.ToString(RandomName) + ext));
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Vale vastus");
                    } 
                }
            }
        }
    }
}
