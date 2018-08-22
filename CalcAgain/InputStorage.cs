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
        }

        public void StoreValue(InputReader inputReader)
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
