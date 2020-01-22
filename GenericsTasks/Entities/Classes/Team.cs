using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Classes
{
    public class Team : Entity
    {
        public string Name { get; set; }
        public List<Player> players = new List<Player>();

    }
}
