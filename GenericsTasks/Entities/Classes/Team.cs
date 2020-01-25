using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Classes
{
    public class Team : Entity
    {
        public Team(int id)
        {
            Id = id;
        }
        public string Name { get; set; }
        public List<Player> players = new List<Player>();

    }
}
