using System;
using TdLib;

namespace TelegramTdLib
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            try
            {
                TdLog.SetVerbosityLevel(0);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("End");
            }

            Console.ReadLine();
        }
    }
}
