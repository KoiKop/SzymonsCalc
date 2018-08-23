using System.Threading;

namespace CalcAgain
{
    public static class Configuration
    {
        public static  string DecimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
    }
}
