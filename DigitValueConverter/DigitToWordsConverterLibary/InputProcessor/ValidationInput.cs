using DigitToWordsConverter.Data;

namespace DigitToWordsConverter.InputProcessor
{
    /// <summary>
    /// Validate input value
    /// </summary>
    public class ValidationInput
    {
        public static ErrorCode IsValidInput(string digit)
        {
            int parseNumber = 0;
            if (int.TryParse(digit,out parseNumber))
            {
                return ErrorCode.Valid;
            }

            return ErrorCode.NotValid;
        }
    }
}
