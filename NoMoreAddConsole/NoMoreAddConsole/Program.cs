using System;

namespace NoMoreAddConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string DDI, DDD, Num, result;

            Information information = new Information();
            Generation generation = new Generation();
            Handler handler = new Handler();

            DDI = handler.HandleDDI(information.CatchDDI());
            DDD = handler.HandleDDD(information.CatchDDD());
            Num = handler.HandleNumber(information.CatchNumber());

            result = $"{DDI}{DDD}{Num}";
            generation.PrintLink(generation.GenerateLink(result));
        }
    }
}
