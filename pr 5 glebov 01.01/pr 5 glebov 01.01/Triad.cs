using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_5_glebov_01._01
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
    }
}
