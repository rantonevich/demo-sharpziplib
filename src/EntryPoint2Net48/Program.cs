using System;
using Lib2NetStand2;

namespace EntryPoint2Net48
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
