using System;
using System.IO;
using System.IO.Compression;
namespace CompressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CompressFile(@"C:\Users\Компьютер\Desktop\Новый текстовый документ.txt", @"C:\Users\Компьютер\Desktop\Новый текстовый документ.txt.gz");
            UncompressFile(@"C:\Users\Компьютер\Desktop\Новый текстовый документ.txt.gz", @"C:\Users\Компьютер\Desktop\Новый текстовый документ1.txt");
        }
        static void CompressFile(string inFilename, string outFilename)
        {
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.Create(outFilename);

            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            int theByte = sourceFile.ReadByte();
            while (theByte != -1)
            {
                compStream.WriteByte((byte)theByte);
                theByte = sourceFile.ReadByte();
            }
            compStream.Close();
        }
        static void UncompressFile(string inFilename, string outFilename)
        {
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.Create(outFilename);
            GZipStream compStream = new GZipStream(sourceFile, CompressionMode.Decompress);
            int theByte = compStream.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte); theByte = compStream.ReadByte();
            }
            compStream.Close();
        }


    }
}