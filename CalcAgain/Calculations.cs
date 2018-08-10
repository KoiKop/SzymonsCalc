using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAgain
{
    class Calculations
    {
        public double Calculate(Action action, double lValue, double rValue)
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




        //public string Calculate(Action action)
        //{
        //    if (Input != "")
        //        RightValue = Convert.ToDouble(Input);

        //    switch (action)
        //    {
        //        case Action.Initial:
        //            LeftValue = RightValue;
        //            break;
        //        case Action.Add:
        //            LeftValue += RightValue;
        //            break;
        //        case Action.Extract:
        //            LeftValue = LeftValue - RightValue;
        //            break;
        //        case Action.Multiple:
        //            LeftValue = LeftValue * RightValue;
        //            break;
        //        case Action.Divide:
        //            if (RightValue == 0)
        //                Input = "Cannot divide by 0";
        //            else
        //                LeftValue = LeftValue / RightValue;
        //            break;
        //    }

        //    RightValue = 0;
        //    Input = string.Empty; //hmmm - co z tym?


        //    if (string.IsNullOrEmpty(Input))
        //        return LeftValue.ToString();
        //    else
        //    {
        //        return Input;
        //        displayInfo = string.Empty;
        //        Cancel();
        //    }

            
        //}

        //public string DisplayResult()
        //{

        //}

        
    }
}
