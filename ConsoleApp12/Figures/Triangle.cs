using System;

namespace ConsoleApp12
{
    class Triangle : IFigure
    {
        private int _sideA; 
        private int _sideB;
        private int _sideC;
        
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
        public int SideC
        {
            get
            {
                return _sideC;
            }
            set
            {
                if (value == _sideC) return;
                _sideC = value;
            }
        }
        #endregion

        public bool IsSquare => SideC * SideC == SideA * SideA + SideB * SideB ? true : false;

        public double Area
        {
            get
            {
                var p = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }
        }

        public Triangle(int sideA, int sideB, int sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public void Display()
        {
            Console.WriteLine($"This is a triangle with sildes: {SideA}, {SideB}, {SideC}. It's {(IsSquare ? "square" : "not square")} and it's area is {Area:f2}"); 
        }

    }
}
