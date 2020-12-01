using System;
using Lib1Net48;

namespace EntryPoint1Net48
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
