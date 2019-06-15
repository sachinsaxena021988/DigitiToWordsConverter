using Shared.Logging;

namespace DigitToWordsConverter.ConverterProcessor
{
    /// <summary>
    /// Asia Converter Processor Convert number to words
    /// </summary>
    public class AsiaConvertProcessor : IConverterProcessor
    {
        #region PrivateVariable

        /// <summary>
        /// logger for error
        /// </summary>
        public ILogger Logger { get; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for asia region
        /// </summary>
        /// <param name="logger"></param>
        public AsiaConvertProcessor(ILogger logger)
        {
            Logger = logger;
        }

        #endregion

        #region Public Method

        /// <summary>
        /// convert digit to number
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        public string ConvertDigitToString(int digit)
        {
            return string.Empty;
        }

        #endregion
    }
}
