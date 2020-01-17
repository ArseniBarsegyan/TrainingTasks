using System;

namespace InitializationOrderTask.Abstract
{
    public abstract class Car
    {
        private int _speed;
        public Car(int speed)
        {
            _speed = speed;
            MaxSpeed = 10;
        }
        public int MaxSpeed { get; set; }

        public void Drive()
        {
            if (_speed > 0)
            {
                Console.WriteLine($"Driving with speed {_speed}");
            }
        }

        public void Accelerate()
        {
            if (_speed < MaxSpeed)
            {
                _speed++;
                Console.WriteLine($"Accelerating to speed {_speed}");
            }
            else
            {
                Console.WriteLine($"Car is driving at maximum speed {MaxSpeed}");
            }
        }

        public void Decelerate()
        {
            _speed--;
            Console.WriteLine($"Decelerating to speed {_speed}");
        }
    }
}
