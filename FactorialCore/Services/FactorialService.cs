﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialCore.Services
{
    public class FactorialService : IFactorialService
    {
        public double GetFactorial(int n)
        {
            if (n <= 1) return 1;
            return n * GetFactorial(n - 1);
        }
    }
}