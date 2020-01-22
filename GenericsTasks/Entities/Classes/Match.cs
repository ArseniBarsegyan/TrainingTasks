using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.Classes
{
    public class Match: Entity
    {
        public DateTime timeOfStart = new DateTime();
        public int Duration { get; set; }
        public string Result { get; set; }
        public Team team1 = new Team();
        public Team team2 = new Team();
    }
}
