using System;
using DigitToWordsConverter.Data;
using Shared.Logging;

namespace DigitToWordsConverter.ConverterProcessor
{
    /// <summary>
    /// British words format Converter
    /// </summary>
    public class BritishConvertProcessor : IConverterProcessor
    {
        #region Private Variable
        
        /// <summary>
        /// logger
        /// </summary>
        private readonly ILogger _logger;

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for british digit 
        /// </summary>
        /// <param name="logger"></param>
        public BritishConvertProcessor(ILogger logger)
        {
            _logger = logger;
        }

        #endregion

        #region Public Method
        /// <summary>
        /// Convert Digit To String
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        public string ConvertDigitToString(int digit)
        {
            try
            {
                if (digit < 100)
                {
                    return ConvertDigitRangeTillHundred(digit).ToLower();
                }
                if (digit < 1000)
                {
                    return ConvertDigitWithinTheRangeOfThousand(digit).ToLower();
                }

                for (int i = 0; i < Constant.OrdinalNumber.Length; i++)
                {
                    int startDigit = i - 1;
                    double powDigit = Math.Pow(1000, i);
                    if (powDigit > digit)
                    {
                        int mod = Convert.ToInt32(Math.Pow(1000, startDigit));
                        int l = digit / mod;
                        int r = digit - (l * mod);
                        string value = ConvertDigitWithinTheRangeOfThousand(l) + " " + Constant.OrdinalNumber[startDigit];
                        if (r > 0)
                        {
                            value = value + " " + ConvertDigitToString(r);
                        }
                        return value.ToLower().TrimEnd(' ');
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return string.Empty;
        }

        #endregion

        #region Private Method

        private string ConvertDigitRangeTillHundred(int digit)
        {
            try
            {
                if (digit < 20)
                {
                    return Constant.ZeroToNineteen[digit].ToLower();
                }

                for (int i = 0; i < Constant.MultipleOfTen.Length; i++)
                {
                    string digitValue = Constant.MultipleOfTen[i];
                    int sval = 20 + 10 * i;
                    if (sval + 10 > digit)
                    {
                        var remainder = digit % 10;
                        if (remainder != 0)
                        {
                            return digitValue + " " + Constant.ZeroToNineteen[remainder].ToLower();
                        }
                        return digitValue.ToLower();
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return string.Empty;
        }

        private string ConvertDigitWithinTheRangeOfThousand(int digit)
        {
            try
            {
                string word = "";
                int rem = digit / 100;
                int mod = digit % 100;
                if (rem > 0)
                {
                    word = Constant.ZeroToNineteen[rem] + " hundred";
                    if (mod > 0)
                    {
                        word = word + " " +"and" + " ";
                    }
                }
                if (mod > 0)
                {
                    word = word + ConvertDigitRangeTillHundred(mod);
                }
                return word.ToLower();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return string.Empty;
        }

        #endregion
    }
}
