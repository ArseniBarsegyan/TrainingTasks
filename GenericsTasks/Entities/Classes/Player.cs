using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Classes
{
    public class Player : Entity
    {
        public string Name { get; set; }
        public Team team = new Team();
        List<Match> matches = new List<Match>();
    }
}
