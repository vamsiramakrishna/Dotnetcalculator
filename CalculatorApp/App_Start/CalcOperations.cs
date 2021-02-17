using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorApp
{
    public class CalcOperations
    {
        public static double Addition (double a, double b)
        {
            double result = a + b;
            result = Math.Round(result, 2);
            return result;
        }

        public static double Subtraction(double a, double b)
        {
            double result = a - b;
            result = Math.Round(result, 2);
            return result;
        }

        public static double Multiplication(double a, double b)
        {
            double result = a * b;
            result = Math.Round(result,2);
            return result;
        }

        public static double Division(double a, double b)
        {
            double result = a / b;
            result = Math.Round(result, 2);
            return result;
        }
    }
}