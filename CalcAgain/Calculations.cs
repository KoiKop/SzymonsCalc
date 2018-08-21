using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAgain
{
    public class Calculations
    {
        InputOperations inputOperations = new InputOperations();

        double lValue = 



        public double Calculate()
        {
            switch (action)
            {
                case Action.Add:
                    lValue += rValue;
                    break;
                case Action.Extract:
                    lValue = lValue - rValue;
                    break;
                case Action.Multiple:
                    lValue = lValue * rValue;
                    break;
                case Action.Divide:
                        lValue = lValue / rValue;
                    break;
            }
            return lValue;
        }


    }
}
