using System.Collections.Generic;

namespace Entities.Classes
{
    public class Player : Entity
    {
        // Это необязательно и даже ненужно убери. Свойства делаются как раз
        // для того, чтобы не обязательно было вызывать конструктор.
        // Инициализацией этого поля будет заниматься либо код, выше репозитория
        // (обычно это сервисы), либо сам Entity framework
        public Player(int id)
        {
            Id = id;
        }
        public string Name { get; set; }
        public Team Team { get; set; }
        public List<Match> Matches { get; set; }
    }
}
