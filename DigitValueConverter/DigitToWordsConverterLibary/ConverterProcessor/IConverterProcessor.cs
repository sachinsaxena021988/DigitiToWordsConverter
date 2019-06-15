namespace DigitToWordsConverter.ConverterProcessor
{
    /// <summary>
    /// IConverterProcessor interface
    /// </summary>
    public interface IConverterProcessor
    {
        /// <summary>
        /// Convert Digit To String
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        string ConvertDigitToString(int digit);
    }
}
