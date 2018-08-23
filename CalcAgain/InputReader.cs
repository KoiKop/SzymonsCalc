using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAgain
{
    public class InputReader
    {
        public string Input { get; set; }


        public InputReader()
        {
            Input = "0";
        }

        public string UpdateInput(string input)
        {
            Input += input;
            TrimFirstZero(Input);
            return Input;
        }

        private void TrimFirstZero(string input)
        {
            if (Input.Length >= 2 && Input[0] == '0')
                Input = Input.Remove(0, 1);
        }
 
        public string AddCommaToInput()
        {
            if (!Input.Contains(Configuration.DecimalSeparator))
                return UpdateInput(Configuration.DecimalSeparator);
            else
                return Input;
        }

        public string ChangePlusMinusSign()
        {
            if (Input.Contains("-"))
                Input = Input.Remove(0, 1);
            else
                Input = Input.Insert(0, "-");

            return Input;
        }

        public string DeleteLastCharacter()
        {
            if ((Input.Length) >= 1)
            {
                Input = Input.Remove(Input.Length - 1);
                if (Input.Length == 0)
                    Input = "0";
            }
            return Input;
        }

        public string ClearInput()
        {
            Input = "0";
            return Input;
        }
    }
}
