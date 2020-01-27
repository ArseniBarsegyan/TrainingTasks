using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Classes
{
    public class Team : Entity
    {
        // Это необязательно и даже ненужно убери. Свойства делаются как раз
        // для того, чтобы не обязательно было вызывать конструктор.
        // Инициализацией этого поля будет заниматься либо код, выше репозитория
        // (обычно это сервисы), либо сам Entity framework
       
        public string Name { get; set; }
        public List<Player> players = new List<Player>();

    }
}
