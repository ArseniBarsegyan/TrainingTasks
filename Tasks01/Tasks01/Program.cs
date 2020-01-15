using System;
using System.Collections.Generic;
using Task1._4Library;

namespace Task01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Task 1 - Это все смотрится так себе. Создай в солюшне несколько проектов
            // типа Class library (C#), и вынеси весь код из этого проекта в них.
            // по логическому признаку (можно разделить по таскам).

            // Task 2 - IFileSystem + FileSystem + WebHelper. Подумай, что тут в не правильно
            // и отрефактори класс согласно принципам SOLID.
            // Подсказка: Тут есть нарушения 3 принципов (Open/Closed, Single responsibility, 
            // Interface Segregation Principle)


            // Task 3 - Dependency Inversion principle
            // Отрефактори класс Warrior, чтобы он мог использовать любое оружие, а не только меч.
            // Создай по аналогии с классом Sword класс лука (Bow).
            // Помимо этого, тут есть еще нарушение принципа. Найди и исправь.

            // Task 4 - В методе Main создай List<IAnimal>, создай несколько панд и енотов
            // и кинь их в эту коллекцию. Подсказка (Liskov Substitution Principle).

            // for Task 1.4: 
            List <IAnimal> zooPark = new List<IAnimal>();
            IAnimal bamboo = new Panda();
            bamboo.GetInfo();
            IAnimal rocket = new Racoon();
            zooPark.Add(bamboo);
            zooPark.Add(rocket);

            Console.ReadKey();
        }
    }
}
