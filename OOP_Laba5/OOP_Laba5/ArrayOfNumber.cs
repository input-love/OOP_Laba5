using System;

namespace OOP_Laba5
{
    class ArrayOfNumber
    {
        public ArrayOfNumber(int size)
        {
            _size_arr = size;
            _arr = new int[_size_arr];
        }
        public void create_arr()
        {
            ScanFile scan_File = new ScanFile();
            scan_File.scan_file(ref _arr, _size_arr);
        }

        public int _size_arr;
        public int[] _arr;
    }
}
