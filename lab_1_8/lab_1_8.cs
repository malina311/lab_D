﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_8
{
    public interface ICalculatorIntegral
    {
        double Calculate(double upper, double lower, int count, Func<double, double> fun);
    }
}
