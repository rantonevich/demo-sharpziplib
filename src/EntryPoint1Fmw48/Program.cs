using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib1Net48;

namespace EntryPoint1Fmw48
{
    class Program
    {
        static void Main(string[] args)
        {
            var bytes = ZipHelper.MakeZipArchiveBytes();
            Console.WriteLine($"Bytes length = {bytes.Length}");
        }
    }
}
