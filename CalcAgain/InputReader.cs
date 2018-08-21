using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalcAgain
{
    public class InputReader
    {
        public string Input { get; set; }

        private readonly string _separator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        public InputReader()
        {
            Input = "0";
        }

        public string UpdateInput(string input)
        {
            Input += input;
            if (Input.Length >= 2 && Input[0] == '0')
                Input = Input.Remove(0, 1);

            return Input;
        }
 
        public string AddCommaToInput()
        {
            if (!Input.Contains(_separator))
                return UpdateInput(_separator);
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
