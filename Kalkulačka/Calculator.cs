using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulačka
{
    public class Calculator
    {
        public float Sum(string string_first_number, string string_second_number)
        {

                float first_number;
                float second_number;
                float result = 0;
            try
            {
                first_number = float.Parse(string_first_number);
                second_number = float.Parse(string_second_number);
            }
            catch
            {
                first_number = 0;
                second_number = float.Parse(string_second_number);
            }
                

            result = first_number + second_number;
            return result;
        }

        public float Deduct(string string_first_number, string string_second_number)
        {
            float first_number;
            float second_number;
            float result = 0;
            try
            {
                first_number = float.Parse(string_first_number);
                second_number = float.Parse(string_second_number);
            }
            catch
            {
                first_number = float.Parse(string_first_number);
                second_number = float.Parse(string_second_number) + 1;
            }

            result = first_number - second_number;
            return result;
        }

        public float Multiply(string string_first_number, string string_second_number)
        {
            float first_number;
            float second_number;
            float result = 0;

            try
            {
                first_number = float.Parse(string_first_number);
                second_number = float.Parse(string_second_number);
            }
            catch
            {
                first_number = 0;
                second_number = 1;
            }

            result = first_number * second_number;
            return result;
        }
        public float Divide(string string_first_number, string string_second_number)
        {
            float first_number;
            float second_number;
            float result = 0;

            try
            {
                first_number = float.Parse(string_first_number);
                second_number = float.Parse(string_second_number);
            }
            catch
            {
                first_number = 0;
                second_number = 1;
            }
            if (first_number == 0)
                result = 0;
            else
                result = first_number / second_number;
            return result;


        }
    }
}
