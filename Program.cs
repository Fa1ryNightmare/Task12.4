using System;

namespace Task12_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ICutDownNotifier[] array = new ICutDownNotifier[3];
            array[0] = new FirstListener(4, "Чтение задания");
            array[1] = new SecondListener(5, "Выполнение задания");
            array[2] = new ThirdListener(2, "Проверка задания перед отправкой");
            array[0].Init();
            array[1].Init();
            array[2].Init();

            array[0].Run();
            array[1].Run();
            array[2].Run();

            Console.ReadKey();
        }
    }
}
