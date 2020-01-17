using InitializationOrderTask.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InitializationOrderTask.Classes
{
    public class Lambargini : Car
    {
        public Lambargini(int speed) : base(speed)
        {
            MaxSpeed = 300;
        }

    }
}
