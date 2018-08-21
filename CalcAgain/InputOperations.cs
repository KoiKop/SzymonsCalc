using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAgain
{
    public class InputOperations
    {
        public double LValue { get; set; }
        public double RValue { get; set; }
        public Action Action { get; set; }

        InputOperations()
        {
            Action = Action.Initial;
        }
        

        InputReader inputReader = new InputReader();

        public void ValueUpdater()
        {
            if (Action == Action.Initial)
            {
                LValue = Convert.ToDouble(inputReader.Input);
                inputReader.ClearInput();
            }
            else
                RValue = Convert.ToDouble(inputReader.Input);
        }

        public void SetAction(Action action)
        {
            Action = action;
        }

    }
}
