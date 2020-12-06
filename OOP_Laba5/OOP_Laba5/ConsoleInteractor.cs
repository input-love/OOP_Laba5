using System;

namespace OOP_Laba5
{
    class ConsoleInteractor
    {
        public void start()
        {
            int check = dialog_get_sort_name();
            int size = dialog_get_size_file();

            ArrayOfNumber array_of_number = new ArrayOfNumber(size);
            array_of_number.create_arr();

            shape_factory(check, ref array_of_number);

            print_file(ref array_of_number);
        }

        private int dialog_get_sort_name()
        {
            int check;
            do
            {
                print_menu_check();
                check = Convert.ToInt32(Console.ReadLine());
            } while(check < 1 || check > 2);
            return check;
        }

        private int dialog_get_size_file()
        {
            int size;
            do
            {
                Console.WriteLine("Сколько элементов считать с файла?:");
                size = Convert.ToInt32(Console.ReadLine());
            } while(size <= 0);
            return size;
        }

        private void shape_factory(int check, ref ArrayOfNumber array_of_number)
        {
            Sorting sorting;
            if(check == 1)
            {
                sorting = new Quick();
                array_of_number._arr = sorting.sort(array_of_number._arr, array_of_number._size_arr);
            }
            else if(check == 2)
            {
                sorting = new Choice();
                array_of_number._arr = sorting.sort(array_of_number._arr, array_of_number._size_arr);
            }
        }

        private void print_file(ref ArrayOfNumber array_of_number)
        {
            PrintFile print_file = new PrintFile();
            print_file.print_file(ref array_of_number);
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
