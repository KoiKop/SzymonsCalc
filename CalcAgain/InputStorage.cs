using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAgain
{
    public class InputStorage
    {
        public double LValue { get; set; }
        public double RValue { get; set; }
        public Action Action { get; set; }

        public InputStorage()
        {
            Action = Action.Initial;
            LValue = double.NaN;
            RValue = double.NaN;
        }

        public void StoreValue(InputReader inputReader)
        {
            if (Action == Action.Initial)
            {
                LValue = Convert.ToDouble(inputReader.Input);
                inputReader.SetInputToNull();
            }
            else
            {
                if (!String.IsNullOrEmpty(inputReader.Input))
                {
                    RValue = Convert.ToDouble(inputReader.Input);
                }
            }

        }

        public void SetAction(Action action)
        {
            Action = action;
        }

        public void SetLValueToNaN()
        {
            LValue = double.NaN;
        }

        public void SetRValueToNaN()
        {
            RValue = double.NaN;
        }
    }
}