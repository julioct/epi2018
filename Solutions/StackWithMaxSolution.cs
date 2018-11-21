using System;
using System.Collections.Generic;

namespace EPI2018.Solutions
{
    public class StackWithMaxSolution
    {
        private Stack<ElementWithCachedMax> stack = new Stack<ElementWithCachedMax>();

        public void Push(int x){
            stack.Push(new ElementWithCachedMax(){
                Element = x,
                Max = Math.Max(x, Max())
            });            
        }

        public int Pop(){
            return stack.Pop().Element;
        }

        public int Max(){
            return stack.Count == 0 ? int.MinValue : stack.Peek().Max;
        }

        public class ElementWithCachedMax {
            public int Element;
            public int Max;            
        }        
    }    
}
