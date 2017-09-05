using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CPE200Lab1
{
    class RpnCalculatorEngine : CalculatorEngine
    {
        private void testStackMethod()
        {
            Stack testStack = new Stack();
            for (int i =1; i <3; i++)
            {
                testStack.Push(i.ToString() + " element");
                
            }
            
        }
    }
}
