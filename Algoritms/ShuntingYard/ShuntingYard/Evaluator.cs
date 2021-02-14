using System;
using System.Collections.Generic;
using System.Text;

namespace ShuntingYard
{
    public class Evaluator
    {
        static bool IsNumber(string n)
        {
            double retNum;
            bool isNumeric = double.TryParse(n, out retNum);
            return isNumeric;
        }
        public double Evaluate(List<string> tokens)
        { 
            Stack<double> resultStack = new Stack<double>();
            foreach (var token in tokens)
            {
                double leftOperand;
                double rightOperand; 
                if (IsNumber(token.ToString()))
                {
                    resultStack.Push(double.Parse(token.ToString()));
                }
                switch (token)
                { 
                    case "+":
                        resultStack.Push(resultStack.Pop() + resultStack.Pop());
                        break;
                    case "-":
                        rightOperand = resultStack.Pop();
                        resultStack.Push(resultStack.Pop() - rightOperand);
                        break;
                    case "*":
                        resultStack.Push(resultStack.Pop() * resultStack.Pop());
                        break;
                    case "/":
                        rightOperand = resultStack.Pop();
                        leftOperand = resultStack.Pop(); 
                        resultStack.Push(leftOperand / rightOperand);
                        break;
                    case "^":
                        rightOperand = resultStack.Pop();
                        leftOperand = resultStack.Pop();
                        resultStack.Push(Math.Pow(leftOperand, rightOperand));
                        break; 
                }
            } 
            return resultStack.Pop();
        }
    }
}
