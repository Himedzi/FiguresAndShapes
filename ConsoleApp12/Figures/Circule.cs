using System;

namespace ConsoleApp12
{
    class Circule : IFigure
    {
        private int _radius;
        
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value == _radius) return;
                _radius = value;
            }
        }

        public Circule(int radius)
        {
            _radius = radius;
        }

        public double Area => Math.PI * Math.Pow(Radius, 2);

        public void Display()
        {
            Console.WriteLine($"This is a cirlce, it's radius is {Radius}. Cirlce's area is {Area:f2}"); ;
        }
    }
}
