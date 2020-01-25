using System.Collections.Generic;

namespace Entities.Classes
{
    public class Player : Entity
    {
        public Player(int id)
        {
            Id = id;
        }
        public string Name { get; set; }
        public Team Team { get; set; }
        public List<Match> Matches { get; set; }
    }
}
