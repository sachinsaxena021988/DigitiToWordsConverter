using DigitToWordsConverter.ConverterProcessor;
using DigitToWordsConverter.Data;
using Shared.Logging;

namespace DigitToWordsConverter.Factory
{
    /// <summary>
    /// Factory to handle object creation
    /// </summary>
    public class ConverterFactory
    {
        #region Public Method
        /// <summary>
        /// Factory for Convert Value based on region
        /// </summary>
        /// <param name="eCountryEnum"></param>
        /// <param name="logger"></param>
        /// <returns></returns>
        public static IConverterProcessor GetProcessorFactory(CountryEnum eCountryEnum,ILogger logger)
        {
            switch (eCountryEnum)
            {
                case CountryEnum.British:
                    return new BritishConvertProcessor(logger);
                case CountryEnum.Asia:
                    return new AsiaConvertProcessor(logger);
                case CountryEnum.UnitedState:
                    return new AsiaConvertProcessor(logger);
            }

            return new BritishConvertProcessor(logger);
        }

        #endregion
    }
}
