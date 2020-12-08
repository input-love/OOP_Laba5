using System;
using System.IO;
using System.Text;

namespace OOP_Laba5
{
    class PrintFile
    {
        public void print_file(ref int[] arr)
        {
            string path = @"result.txt";
            using (StreamWriter fout = new StreamWriter(path, false))
            {
                for (int i = 0; i < arr.Length; ++i)
                {
                    fout.Write($"{arr[i]}\n");
                }
            }
        }
    }
}