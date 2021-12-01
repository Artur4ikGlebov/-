using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_7_glebov_01._01
{
    class Triad
    {

        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }

        public Triad()
        {
            First = 0;
            Second = 0;
            Third = 0;
        }

        public Triad(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public void SetParams(int number)
        {
            First = Second = Third = number;
        }

        public void SetParams(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public int GetSumOfNumbers()
        {
            return First + Second + Third;
        }

        public static bool operator true(Triad triad)
        {
            return triad.First == triad.Second && triad.Second == triad.Third;
        }

        public static bool operator false(Triad triad)
        {
            return triad.First != triad.Second && triad.Second != triad.Third;
        }

        // Метод описан, но не используется
        public bool IsTriadsEqual(Triad triad1, Triad triad2)
        {
            return triad1.First == triad2.First && triad1.Second == triad2.Second && triad1.Third == triad2.Third;
        }
    }

    class Triangle : Triad
    {

        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }

        public Triangle(int sideA, int sideB, int sideC) : base(sideA, sideB, sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Area()
        {
            double p = (SideA + SideB + SideC) / 2.0;
            double area = Math.Round(Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)), 4);
            return area;
        }

        public (double angle1, double angle2, double angle3) Angles()
        {
            //double angle1 = Math.Round(Math.Cos((Math.Pow(SideA, 2) + Math.Pow(SideC, 2) - Math.Pow(SideB, 2)) / 2.0 * SideA * SideC), 2);
            double angle1 = Math.Round(Math.Acos((SideA * SideA + SideB * SideB - SideC * SideC) / (2.0 * SideA * SideB)) * 180 / Math.PI, 2);
            double angle2 = Math.Round(Math.Acos((SideA * SideA + SideC * SideC - SideB * SideB) / (2.0 * SideA * SideC)) * 180 / Math.PI, 2);
            double angle3 = Math.Round(180 - angle1 - angle2, 2);
            return (angle1, angle2, angle3);
        }
    }
}
