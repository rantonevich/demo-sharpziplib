using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;

namespace Lib1Net48
{
    public class ZipHelper
    {
        public static byte[] MakeZipArchiveBytes()
        {
            using (var stream = new MemoryStream())
            {
                using (var zipStream = new ZipOutputStream(stream))
                {
                    zipStream.SetLevel(9);
                    var buffer = new byte[] {1, 10, 100};
                    var entry = new ZipEntry("abc") {DateTime = DateTime.Now};
                    zipStream.PutNextEntry(entry);
                    zipStream.Write(buffer, 0, buffer.Length);
                    zipStream.Finish();
                    zipStream.Close();
                }

                return stream.ToArray();
            }
        }
    }
}