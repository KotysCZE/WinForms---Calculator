using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulačka
{
    public class UserInputs
    {
        Calculator calc = new Calculator();
        public string first_number;
        public string second_number;

        private string number_switcher; //dočasná proměná sloužící k uložení dat zadaných uživatelem
        private string action_button;
        private int round_count = 0; //proměnná round_count slouží k ověření o kolikátý cyklus se jedná
        public void Add(string number)
        {
            number_switcher += number; //při zmáčknutí číslice se stringová hodnota přičte k proměnné
        }

        public void Plus()
        {
            if (round_count == 0)
            {
                first_number = number_switcher; //pokud se jedná o první cyklus, do první číslice se uloží switcher a switcher se vynuluje
                action_button = "+"; //action button se změní na základě uživatelem zvolné akce
                number_switcher = "";
            }
            else action_button = "+"; //pokud se jedná o několikátý cyklus, změní se pouze action_button
        }
        public void Minus()
        {
            if (round_count == 0)
            {
                first_number = number_switcher;
                action_button = "-";
                number_switcher = "";
            }
            else action_button = "-";
        }
        public void Multiply()
        {
            if (round_count == 0)
            {
                first_number = number_switcher;
                action_button = "*";
                number_switcher = "";
            }
            else action_button = "*";
        }
        public void Divide()
        {
            if (round_count == 0)
            {
                first_number = number_switcher;
                action_button = "/";
                number_switcher = "";
            }
            else action_button = "/";
        }

        public void Clear() //vynuluje nám round_counta vymaže všechny proměnné
        {
            first_number = "";
            second_number = "";
            number_switcher = "";
            round_count = 0;
           
        }

        public string Final_result()
        {
        
            float result = 0;
 
            second_number = number_switcher;
            round_count++;

            if (action_button == "+")
            {
                result = calc.Sum(first_number, second_number);
                first_number = result.ToString();
                number_switcher = "";
            }
            else if (action_button == "-")
            {
                result = calc.Deduct(first_number, second_number);
                first_number = result.ToString();
                number_switcher = "";
            }
            else if (action_button == "*")
            {
                result = calc.Multiply(first_number, second_number);
                first_number = result.ToString();
                number_switcher = "";
            }
            else if (action_button == "/")
            {
                result = calc.Divide(first_number, second_number);
                first_number = result.ToString();
                number_switcher = "";
            }

            return result.ToString() ;
        }
    }    
}
