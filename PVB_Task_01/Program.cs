using System;

namespace PVB_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Gold:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Сколько у вас золота?");
            Console.ResetColor();

            uint Gold;
            try
            {
                Gold = Convert.ToUInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                goto Gold;
            }
            catch (OverflowException)
            {
                goto Gold;
            }
            uint Crystal = 3;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Вы можете купить максимум " + Gold / Crystal + " Стоимость кристалла " + Crystal + " (за один).");
            Console.ResetColor();

            Crystal:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Сколько хотите купить кристалов?");
            Console.ResetColor();

            uint Buy;
            try {
                Buy = Convert.ToUInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                goto Crystal;
            }
            catch(OverflowException)
            {
                goto Crystal;
            }

            uint Max_buy = Gold / Crystal;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Вы купили " + Buy + " кристалов. У вас осталось " + (Gold - Buy * Crystal) + " золота");
            Console.ResetColor();

            Console.ReadKey();


        }

    }
}
