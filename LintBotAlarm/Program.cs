using System;

namespace LintBotAlarm
{
    class Program
    {
        static void Main(string[] args)
        {
            LineNotify.Create("Bearer_XXX", false).SendMessage("default alarm");
            Console.ReadLine();
            LineNotify.CreateError().SendMessage("error alarm");
            Console.ReadLine();
            LineNotify.CreateInfo().SendMessage("info alarm");
            Console.ReadLine();
        }
    }
}
