using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulačka
{
    
    public static class LogManager
    {
        public static void WriteLog(string method, string first_number, string action,string second_number)
        {
            string line;
            int lines_of_log=0;
            List<string> logs = new List<string>();
            StreamReader sr = new StreamReader(@"CalculatorLogs.txt");
            while ((line = sr.ReadLine()) != null)
            {
                logs.Add(line);
                foreach(string log in logs)
                {
                    lines_of_log++;
                }
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(@"CalculatorLogs.txt", true);
            sw.WriteLine($"{lines_of_log}{method}: {first_number}{action}{second_number}");
            sw.Close();

        }
        public static void WriteLog(string action)
        {
            string line;
            int lines_of_log = 0;
            List<string> logs = new List<string>();
            StreamReader sr = new StreamReader(@"CalculatorLogs.txt");
            while ((line = sr.ReadLine()) != null)
            {
                logs.Add(line);
                foreach (string log in logs)
                {
                    lines_of_log++;
                }
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(@"CalculatorLogs.txt", true);
            sw.WriteLine($"{lines_of_log}:{action}");
            sr.Close();
        }
    }
}
