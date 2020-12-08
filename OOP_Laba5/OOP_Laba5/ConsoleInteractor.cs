using System;

namespace OOP_Laba5
{
    class ConsoleInteractor
    {
        public void start()
        {
            try
            {
                int check = dialog_get_name_sort();
                string name_file = dialog_get_name_file();
                int size = dialog_get_size_file();

                ScanFile scan_file = new ScanFile();
                int[] arr = scan_file.scan_file(ref name_file, size);

                shape_factory(check, ref arr);

                print_file(ref arr);
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private int dialog_get_name_sort()
        {
            int check;
            do
            {
                print_menu_check();
                check = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (check < 1 || check > 2);
            return check;
        }

        private string dialog_get_name_file()
        {
            string name_file;
            do
            {
                Console.WriteLine("Название файла и его формат: ");
                name_file = Console.ReadLine();
                Console.Clear();
            } while (name_file == "");
            return name_file;

        }
        private int dialog_get_size_file()
        {
            int size;
            do
            {
                Console.WriteLine("Сколько элементов считать с файла?:");
                size = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (size <= 0);
            return size;
        }
        private void shape_factory(int check, ref int[] arr)
        {
            Sorting sorting;
            if (check == 1)
            {
                sorting = new Quick();
                sorting.sort(ref arr, arr.Length);
            }
            else if (check == 2)
            {
                sorting = new Choice();
                sorting.sort(ref arr, arr.Length);
            }
        }

        private void print_file(ref int[] arr)
        {
            PrintFile print_file = new PrintFile();
            print_file.print_file(ref arr);
            Console.WriteLine("Успешно, файл будет выгружен в корневую папку проекта!");
        }

        private void print_menu_check()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Какую сортировку использовать?");
            Console.WriteLine("1 - Quick");
            Console.WriteLine("2 - Choice");
            Console.WriteLine("-------------------------------");
        }
    }
}
