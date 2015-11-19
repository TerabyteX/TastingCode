using static System.Console;

namespace TastingCode
{
    class FizzBuzz
    {
        internal static void Print(uint upper)
        {
            var step3 = 1;
            var step5 = 1;
            var fStat = 0;
            var bStat = 0;
            var fbStat = 0;

            for (var i = 1; i <= upper; i++)
            {
                if (step3 == 3 && step5 == 5)
                {
                    step3 = step5 = 1;
                    fStat += 1;
                    bStat += 1;
                    fbStat += 1;
                    WriteLine("FizzBuzz");
                }
                else if (step3 == 3)
                {
                    step3 = 1;
                    step5 += 1;
                    fStat += 1;
                    WriteLine("Fizz");
                }
                else if (step5 == 5)
                {
                    step5 = 1;
                    step3 += 1;
                    bStat += 1;
                    WriteLine("Buzz");
                }
                else
                {
                    step3 += 1;
                    step5 += 1;
                }
            }

            WriteLine($"total FizzBuzz = {fbStat}, total Fizz = {fStat}, total Buzz = {bStat}");
        }
    }
}
