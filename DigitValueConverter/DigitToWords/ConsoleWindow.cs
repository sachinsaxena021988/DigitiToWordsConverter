using System;
using DigitToWordsConverter.ConverterProcessor;
using DigitToWordsConverter.Data;
using DigitToWordsConverter.Factory;
using DigitToWordsConverter.InputProcessor;
using Shared;
using Shared.Logging;

namespace DigitToWords
{
    /// <summary>
    /// start Method
    /// </summary>
    class ConsoleWindow
    {
        /// <summary>
        /// load main method
        /// </summary>
        static void Main()
        {
            PreInputMessage();
            ILogger logger = new ConsoleLogger();
            IConverterProcessor numConvert = ConverterFactory.GetProcessorFactory(CountryEnum.British, logger);
           
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                var query = Console.ReadLine();

                if (query == "EXIT")
                    break;

                if (ValidationInput.IsValidInput(query) == ErrorCode.Valid)
                {
                    var result = numConvert.ConvertDigitToString(Convert.ToInt32(query));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(result);
                }
                else
                {
                    logger.LogError("Invalid Input");
                }

                PostInputMessage();
            }

        }

        /// <summary>
        /// Pre Input Message
        /// </summary>
        private static void PreInputMessage()
        {
            Console.Write("Welcome for converting number to words. To Exit at any point , please type EXIT" +
                          Environment.NewLine);
            Console.WriteLine("WAITING FOR  INPUT !!!!");
            Console.WriteLine("___________________________________________________");
        }

        /// <summary>
        /// Post Input Message
        /// </summary>
        private static void PostInputMessage()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("WAITING FOR NEXT INPUT !!!!");
            Console.WriteLine("___________________________________________________");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
