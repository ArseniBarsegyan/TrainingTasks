using System;

namespace Entities.Classes
{
    public class Match : Entity
    {
        public DateTime TimeOfStart { get; set; }
        public int Duration { get; set; }
        public string Result { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
    }
}