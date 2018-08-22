using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAgain
{
    public class Calculations
    {
        public string Calculate(InputStorage input)
        {
            string validationMessage = Validate(input.Action, input.RValue);

            if (String.IsNullOrEmpty(validationMessage))
            {
                switch (input.Action)
                {
                    case Action.Add:
                        input.LValue += input.RValue;
                        break;
                    case Action.Extract:
                        input.LValue = input.LValue - input.RValue;
                        break;
                    case Action.Multiple:
                        input.LValue = input.LValue * input.RValue;
                        break;
                    case Action.Divide:
                        input.LValue = input.LValue / input.RValue;
                        break;
                }
                return input.LValue.ToString();
            }
            else
            {
                return validationMessage;
            }
        }

        private string Validate(Action action, double rValue)
        {
            if (action == Action.Divide && rValue == 0)
                return "Oh! You can't divide by 0!";
            else
                return null;
        }
    }
}
