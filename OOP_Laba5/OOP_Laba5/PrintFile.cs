using System;
using System.IO;
using System.Text;

namespace OOP_Laba5
{
    class PrintFile
    {
        public void print_file(ref ArrayOfNumber array_of_number)
        {
            Encoding unicode = Encoding.Unicode;
            string path = $"{AppDomain.CurrentDomain.BaseDirectory}result.txt";
            using (StreamWriter fout = new StreamWriter(@path, false, unicode))
            {
                int count = array_of_number._size_arr;
                for (int i = 0; i < count; ++i)
                {
                    fout.Write($"{array_of_number._arr[i]}\n");
                }
            }
        }
    }
}
