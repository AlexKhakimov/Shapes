using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Round : Shape
    {
        private double radius;
        public Round(double radius)
        {
            this.radius = radius;
        }
        public override double Area
        {
            get
            {
                return radius * radius * System.Math.PI / 4;
            }
        }

    }

    public class Triangle : Shape
    {
        private double side_1;
        private double side_2;
        private double side_3;

        public Triangle(double side_1, double side_2, double side_3)
        {
            this.side_1 = side_1;
            this.side_2 = side_2;
            this.side_3 = side_3;
        }

        public override double Area
        {
            get
            {
                if (this.IsTriangle())
                {
                    double half_perimetr = (side_1 + side_2 + side_3) / 2;
                    // Given the width and height, return the area of a rectangle:
                    return System.Math.Sqrt(half_perimetr * (half_perimetr - side_1) * (half_perimetr - side_2) * (half_perimetr - side_3));
                }
                else
                {
                    throw new System.Exception("Not a triangle");
                }
              
            }
        }

        public bool IsTriangle()
        { 
           double max_side=System.Math.Max(side_1,System.Math.Max(side_2,side_3));
           double min_side_1=System.Math.Min(side_2,side_3);
           double min_side_2=System.Math.Min(side_2,side_1);
            if(max_side<min_side_1+min_side_2)
            {
            return true;
            }
            return false;
        }

        public bool IsRightTriangle()
        { 
            double hypotenuse=System.Math.Max(side_1,System.Math.Max(side_2,side_3));
            double cathete_1=System.Math.Min(side_2,side_3);
            double cathete_2=System.Math.Min(side_2,side_1);
            if (hypotenuse*hypotenuse==(cathete_1*cathete_1)+(cathete_2*cathete_2))
            {
            return true;
            }
            return false;
        }

    }

    public class AnyShape : Shape
    {
        //определить правило принадлежности точек фигуре
        Points point;

        public override double Area
        {
            get
            {
                double area_monte_carlo = 0;
                Random random = new Random();
                for (int i = 1; i < 1000; i++)
                { 
                 double point_1 = random.Next(0, 1);
                 double point_2 = random.Next(0, 1);
                 if (point(point_1,point_2))
                 {
                     area_monte_carlo++;
                 }
                }
                return area_monte_carlo/1000;
            }
        }
    }
}
