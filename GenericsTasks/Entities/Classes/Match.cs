using System;

namespace Entities.Classes
{
    public class Match : Entity
    {
        // Это необязательно и даже ненужно убери. Свойства делаются как раз
        // для того, чтобы не обязательно было вызывать конструктор.
        // Инициализацией этого поля будет заниматься либо код, выше репозитория
        // (обычно это сервисы), либо сам Entity framework
        public Match(int id)
        {
            Id = id;
        }
        public DateTime TimeOfStart { get; set; }
        public int Duration { get; set; }
        public string Result { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
    }
}