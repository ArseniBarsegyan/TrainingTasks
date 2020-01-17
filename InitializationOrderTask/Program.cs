using InitializationOrderTask.Abstract;
using InitializationOrderTask.Classes;
using System;

namespace InitializationOrderTask
{
    // 1. Создай класс Lamborgini и унаследуй его от класса Car
    // Lamborgini должен иметь максимальную скорость 300.
    // Создай объект Lamborgini и протестируй его максимальную скорость.
    // Исправь ошибку в программе.

    // 2. Создай класс, в котором будет счетчик созданных экземпляров этого класса.
    // Создай несколько экземпляров этого класса и выведи значение счетчика в консоль.
    public class Program
    {
        public static void Main(string[] args)
        {
            //  Task1 testing                        
            Car someLambargini = new Lambargini(299);
            someLambargini.Drive();
            someLambargini.Accelerate();
            someLambargini.Accelerate();

            //Task 2 testing
            Task2 t1 = new Task2();
            Task2 t2 = new Task2();
            Task2.CounterOfObjectsView();
            Task2 t3 = new Task2();
            Task2.CounterOfObjectsView();

            Console.ReadKey();
        }
    }
}
