using System;
using System.IO;
using System.Text;

namespace OOP_Laba5
{
    class ScanFile
    {
        public void scan_file(ref int[] _arr, int size)
        {
            //Encoding unicode = Encoding.Unicode;
            string path = $"{AppDomain.CurrentDomain.BaseDirectory}test.txt";
            if (File.Exists(@path))
            {
                using (StreamReader stream_reader = new StreamReader(@path))
                {
                    string line;
                    for (int i = 0; i < size; ++i)
                    {
                        if ((line = stream_reader.ReadLine()) == null)
                        {
                            throw new Exception("Недопустимое количество элементов в файле!... Завершение работы");
                        }
                        else
                        {
                            _arr[i] = Parser.parse(ref line);
                        }
                    }
                }
            }
            else
            {
                throw new Exception("Нет такого файла!... Завершение работы");
            }
        }
    }
}
