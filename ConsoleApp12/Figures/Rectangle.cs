using System;

namespace ConsoleApp12
{
    class Rectangle : IFigure
    {
        private int _sideA;
        private int _sideB;

        #region Sides
        public int SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                if (value == _sideA) return;
                _sideA = value;
            }
        }
        public int SideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                if (value == _sideB) return;
                _sideB = value;
            }
        }
        #endregion

        public bool IsSquare => SideA == SideB ? true : false; 

        public Rectangle(int sideA, int sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }

        public double Area => SideA * SideB;

        public void Display()
        {
            Console.WriteLine($"This is a rectangle with sides: {SideA}, {SideB}. It's area is {Area:f2} and it's {(IsSquare ? "square" : "not square")}"); ;
        }
    }
}
