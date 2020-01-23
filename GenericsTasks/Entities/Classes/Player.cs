using System.Collections.Generic;

namespace Entities.Classes
{
    public class Player : Entity
    {
        public string Name { get; set; }
        public Team Team { get; set; }
        public List<Match> Matches { get; set; }
    }
}
