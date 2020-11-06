using System;
using System.IO;

namespace FileDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      StreamWriter writer = File.CreateText(@"C:\Users\student\source\repos\praktika\praktika2\praktikum2\FileDemo\text.txt"); writer.WriteLine("This is my new file");
      writer.WriteLine("Do you like its format?"); writer.Close();
    }
  }
}
