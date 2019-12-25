
namespace ConsoleApp12
{
    public class Creator
    {
        protected string _name;

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

        public Creator(string name)
        {
            _name = name;
        }

        public IFigure Create()
        {
            return new EmptyFigure(Name);
        }
    }

    public class TriangleCreator: Creator
    {
        public TriangleCreator(string name) : base(name)
        {
            _name = name;
        }

        public IFigure Create(int sideA, int sideB, int sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }
    }

    public class RectangleCreator : Creator
    {
        public RectangleCreator(string name) : base(name)
        {
            _name = name;
        }

        public IFigure Create(int sideA, int sideB)
        {
            return new Rectangle(sideA, sideB);
        }
    }

    public class CirculeCreator : Creator
    {
        public CirculeCreator(string name) : base(name)
        {
            _name = name;
        }

        public IFigure Create(int radius)
        {
            return new Circule(radius);
        }
    }
}
