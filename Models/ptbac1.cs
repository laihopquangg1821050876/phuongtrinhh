using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace phuongtrinhb1.Models
{
    public class ptbac1
    {
        public double Timx( double a, double b )
        {
            double giattrix = 0;
            giattrix = - a / b;
            return giattrix;




        }
        public double GPT(double x, double y)
        {
            double GPT = 0;
            GPT = -x / y;
            GPT = -y / x;
            return GPT;
        }
}
