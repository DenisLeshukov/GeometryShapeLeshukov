using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Rectangle:Shape
    {
        private double Width { get; set; }
        private double Height { get; set; }
        public Rectangle (double _wight, double _height)
        {
            Height = _height;
            Width = _wight;
        }
        public override double Area()
        {
            if(Width > 0 && Height > 0)
            {
                return Width * Height;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Неверные данные (стороны должжны быть > 0)");
            }
            
        }
        public override double Perimeter()
        {
            if (Width > 0 && Height > 0)
            {
                return (Width + Height) * 2;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Неверные данные (стороны должжны быть > 0)");
            }
           
        }
        public override string ToString()
        {
            return $"Прямоугольник: высота={Height}, ширина={Width}";
        }
    }
}
