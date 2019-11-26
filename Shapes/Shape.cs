using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        private string name;
        public abstract double Area { get; }
        //делегат может задавать  фигуру на плоскости путем определения
        // принадлежит ли указанная точка внутренности фигуры
        public delegate bool Points(double x, double y);
    }

}
