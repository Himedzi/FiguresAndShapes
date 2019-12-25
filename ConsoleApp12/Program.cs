using System;
using System.Collections.Generic;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFigure> PackOfFigures = new List<IFigure>
            {
                new CirculeCreator("Circule_1").Create(5),
                new RectangleCreator("Rectangle_1").Create(4, 5),
                new RectangleCreator("Rectangle_2").Create(3, 3),
                new TriangleCreator("Triangle_1").Create(10, 24, 26),
                new TriangleCreator("Triangle_1").Create(11, 9, 6)
            };

            foreach (IFigure figure in PackOfFigures)
            {
                figure.Display();
            }

            Console.ReadKey();
        }
    }
}
