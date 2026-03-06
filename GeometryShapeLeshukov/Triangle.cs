using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Triangle:Shape
    {
        private double SideA { get; set; } 
        private double SideB { get; set; }
        private double SideC { get; set; }
        public Triangle (double _sideA,double _sideB, double _sideC)
        {

            SideA = _sideA;
            SideB = _sideB;
            SideC = _sideC;
 
        }
        public override double Area ()
        {
            if (SideA + SideB > SideC)
            {
                if (SideA > 0 && SideB > 0 && SideC > 0)
                {
                    double p = (SideA + SideB + SideC) / 2;
                    return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
                }
                else
                { 
                    throw new ArgumentOutOfRangeException("Неверные данные (стороны должжны быть > 0)");
                }

            }
            return -1;
        }
        public override double Perimeter ()
        {
            if(SideA+SideB>SideC)
            {
                if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                {
                    throw new ArgumentOutOfRangeException("Неверные данные (стороны должжны быть > 0)");
                }
                else
                {
                    return SideA + SideB + SideC;
                }
                
            }
            return 0;
            
        }
        public override string ToString ()
        {
            return $"Треугольник: сторона а={SideA}, сторона b= {SideB}, сторона с={SideC}";
        }
    }
}
