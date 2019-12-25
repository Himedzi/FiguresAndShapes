using System;

namespace ConsoleApp12
{
    public class EmptyFigure : IFigure
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == _name) return;
                _name = value;
            }
        }
        public double Area => 0.0;

        public EmptyFigure(string name)
        {
            _name = name;
        }

        public void Display()
        {
            Console.WriteLine("This is an empty figure"); ;
        }
    }
}
