using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace phuongtrinhb1.Models
{
    public class PTB1
    {
        
        public double PTB1(double x, double y)
        {
            double GPT = 0;
            GPT = x / y;
            GPT = y / x;
            return GPT;
        }
}
