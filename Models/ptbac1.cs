using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace phuongtrinhb1.Models
{
    public double Timx(double a, double b)
    {
        double gtx = 0;
        gtx = b / a;
        gtx = -b / a;
        return gtx;
    }
}