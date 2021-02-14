using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ShuntingYard
{
    public class ShuntingYardClass
    {
        static int Priority(string symbol)
        {
            if (symbol == "^")
            {
                return 4;
            }
            else if (symbol == "*" || symbol == "/")
            {
                return 3;
            }
            else if (symbol == "+" || symbol == "-")
            {
                return 2;
            }
            else if (symbol == "(")
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        static bool IsNumber(string n)
        { 
            double retNum;
            bool isNumeric = double.TryParse(n, out retNum);
            return isNumeric; 
        }
        public List<string> ShuntingYardAlgorithm(string expression)
        {
            string[] tokens = expression.Split(null);
            List<string> output = new List<string>();
            Stack<string> operators = new Stack<string>(); 
            for (int i = 0; i < tokens.Length; i++)
            {  
                if (IsNumber(tokens[i]) || tokens[i] == ".")
                {
                    output.Add(tokens[i]);
                    continue;
                } 
                switch (tokens[i])
                {
                    case "(": 
                        operators.Push(tokens[i]);
                        break;
                    case "^":
                    case "*":
                    case "/":
                    case "+":
                    case "-":
                        while (operators.Count > 0 && Priority(tokens[i]) <= Priority(operators.Peek().ToString()))
                        {
                            output.Add(operators.Pop().ToString());
                        }
                        operators.Push(tokens[i]);
                        break;
                    case ")":
                        while (operators.Peek() != "(")
                        {
                            output.Add(operators.Pop().ToString());
                        }
                        operators.Pop();
                        break; 
                }
            }   
            while (operators.Any())
            {
                output.Add(operators.Pop().ToString());
            }
            return output;
        }
    }
}

