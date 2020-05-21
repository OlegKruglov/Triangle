using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double r;

        public Triangle(double R)//присваивание значения радиуса
        {
            r = R;
        }
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public string outputR()
        {
            return Convert.ToString(r);
        }
        public double Perimeter()//Вычисление периметра треугольника
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface()//Вычиисление площади
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double Height()//Вычисление высоты треунольника
        {
            double h = 0;
            h = b * c / 2 * r;
            return h;
        }
        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public double GetSetR//свойство позволяющее установить либо изменить значение радиуса
        {
            get
            { return r; }
            set
            { r = value; }
        }
        public bool ExistTriangle//свойство позволяющее установить, существует ли треугольник с заддаными сторонами
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))
                    return false;
                else return true;
            }
        }
    }
}
