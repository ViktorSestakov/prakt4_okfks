using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rectangle : Shape
    {
        private double _width = 0.0;
        private double _height = 0.0;

        public double Width
        {
            get => _width;
            set
            {
                if (_width != value)
                {
                    _width = value;
                }
            }
        }
        public double Height
        {
            get => _height;
            set
            {
                if (_height != value)
                {
                    _height = value;
                }
            }
        }

        public override double Area()
        {
            if (Width < 1 || Height < 1)
            {
                throw new ArgumentException("error!");
            }

            return checked(Width * Height);
        }
        public override double Perimeter()
        {
            if (Width < 1 || Height < 1)
            {
                throw new ArgumentException("error!");
            }

            return checked(2 * (Width + Height));
        }
        public override string ToString()
        {
            return $"Информация о прямоугольнике:\nШирина: {Width}\nВысота: {Height}";
        }
    }
}
