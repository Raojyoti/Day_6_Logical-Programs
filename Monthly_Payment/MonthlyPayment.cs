﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Monthly_Payment
{
    internal class MonthlyPayment
    {
        public static double P, Y, R, monthly_Payment, n, r;
        public static void monthlyPayment()
        {
            n = 12 * Y;
            r = R / (12 * 100);
            monthly_Payment = (P * r) / (1 - (Math.Pow((1 + r), -n)));
            Console.WriteLine(" Monthly Payment is: " + monthly_Payment);
           
        }
       
    }
}
