using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public static class EvaluateRpnSolution
    {
        public static int Eval(string expression){
            var stack = new Stack<int>();
            var parts = expression.Split(",");

            foreach (var part in parts)
            {
                switch(part){
                    case "+":
                        stack.Push(stack.Pop() + stack.Pop());
                        break;
                    case "-":
                        stack.Push(stack.Pop() - stack.Pop());
                        break;
                    case "x":
                        stack.Push(stack.Pop() * stack.Pop());
                        break;
                    case "/":
                        stack.Push(stack.Pop() / stack.Pop());
                        break;
                    default:
                        stack.Push(int.Parse(part));
                        break;
                }
            }

            return stack.Pop();
        }
    }    
}
