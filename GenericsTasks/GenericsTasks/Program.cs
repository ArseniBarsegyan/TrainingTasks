using Entities.Classes;
using GenericsRepo;
using System;
using System.Collections.Generic;

namespace GenericsTasks
{
    // 1. Когда будешь работать с проектом, изначально настрой
    // архитектуру, продумай как что назвать, какие сделать папки, и,
    // возможно, другие сборки (библиотеки кода (dll)) и т.д.
    // 2. Паттерн репозиторий.
    // Почитай, что такое POCO, это очень используемый "паттерн".
    // По сути, это использование простых классов Entities (сущности).
    // Создай в проекте классы Player, Team, Match.
    // Они отвечают, как понятно из названия, за игрока, команду
    // и матч.
    // У игрока есть свойства - имя, текущая команда, список матчей
    // Соответственно, у команды есть название и список игроков
    // У Матча есть время, длительность, 2 соревнующихся команды, результат.
    // Кроме того, у всех Entities есть свойство Id, это общепринятая практика заводить
    // такое поле в сущностях, т.к. оно позволяет показать уникальность этой сущности,
    // (подумай, как это лучше всего сделать с помощью наследования).
    // 3. Создай Generic класс Repository, в котором будет
    // generic коллекция для любых созданных тобой Entities (игрок, команда, матч).
    // Добавь CRUD операции в этот класс (Create, update, delete),
    // ты уже как-то делал это.
    // 4. В методе Main продемонстрируй работу репозитория, типизированного любой из
    // созданных тобой сущностей (репозиторий для команды, игрока или матчей).
    public class Program
    {
        public static void Main(string[] args)
        {
            Match match = new Match { Id = 1 };
            Player player1 = new Player { Id = 2 };
            Team team = new Team { Id = 3 };
            Player player2 = new Player { Id = 4, Name = "Evdokim" };
            
            var entities = new List<Entity>();
            Repository <Entity> repository = new Repository <Entity> (entities);
            repository.Create(player1);
            repository.Create(player2);
            repository.Create(team);
            repository.Create(match);
            repository.Delete(4);
            Player player3 = new Player { Id = 2, Name = "Evlampii" };
            repository.Update(player3);
            Player gottenPlayer  = (Player) repository.GetEntity(2);

            //Viewing of repository content
            var repList= repository.GetAll();
            foreach (var t in repList)
            {
                Console.WriteLine(t);
            }

            //Viewing of repository updating (changing name from "Evdosii" to "Evlampii")
            Console.WriteLine(gottenPlayer.Name);

            Console.ReadKey();
        }
    }
}
