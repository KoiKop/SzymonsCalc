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
            string validationMessage = ValidateDividingByZero(input.Action, input.RValue);

            if (!string.IsNullOrEmpty(validationMessage))
                return validationMessage;

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

        private string ValidateDividingByZero(Action action, double rValue)
        {
            if (action == Action.Divide && rValue == 0)
                return Translations.DivideByZeroMessage;
            else
                return null;
        }
    }
}
