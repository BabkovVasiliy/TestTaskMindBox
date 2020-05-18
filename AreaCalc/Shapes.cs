using System;


namespace AreaCalc
{
    public abstract class Shape
    {
        abstract public double Area();
        abstract public bool IsValid();
    }

    public class Circle : Shape
    {
        private double R;
        public Circle(double r)
        {
             R = r;
        }

        override public double Area()
        {
            if (IsValid())
            {
                return R * R * Math.PI;
            }
            else
            {
                return -1;
            }
        }
        override public bool IsValid()
        {
            return R>= 0? true:false; 
        }

    }

    public class Triangle : Shape
    {
        private double A;
        private double B;
        private double C;
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

        }
        public override double Area()
        {
            double p = (A + B + C) / 2;
            if (IsValid())
            {
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
            else
            {
                return -1;
            }
        }
        public override bool IsValid()
        {
            return (A > 0 && B > 0 && C > 0 && A + B > C && B + C > A && A + C > B);
        }

        public bool IsRightTriangle()
        {
            if (IsValid())
            {
                return (A * A + B * B == C * C || B * B + C * C == A * A || C * C + A * A == B * B);
            }
            else
            {
                return false;
            }
        }


    }
    




}
