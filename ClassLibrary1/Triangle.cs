using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Triangle : Shape
    {
        private double _sideA = 0.0;
        private double _sideB = 0.0;
        private double _sideC = 0.0;

        public double SideA
        {
            get => _sideA;
            set
            {
                if (_sideA != value)
                {
                    _sideA = value;
                }
            }
        }

        public double SideB
        {
            get => _sideB;
            set
            {
                if (_sideB != value)
                {
                    _sideB = value;
                }
            }
        }

        public double SideC
        {
            get => _sideC;
            set
            {
                if (_sideC != value)
                {
                    _sideC = value;
                }
            }
        }

        public override double Area()
        {
            if (SideA < 1 || SideB < 1 || SideC < 1)
            {
                throw new ArgumentException("error!");
            }

            double p = (SideA + SideB + SideC) / 2;
            double S = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));

            return checked(S);
        }
        public override double Perimeter()
        {
            if (SideA < 1 || SideB < 1 || SideC < 1)
            {
                throw new ArgumentException("error!");
            }

            return checked(SideA + SideB + SideC);
        }
        public override string ToString()
        {
            return $"Информация о треугольники:\nСторона 1: {SideA}\nСторона 2: {SideB}\nСторона 3: {SideC}";
        }
    }
}
