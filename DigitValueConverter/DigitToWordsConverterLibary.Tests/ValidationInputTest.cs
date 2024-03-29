using DigitToWordsConverter.Data;
using DigitToWordsConverter.InputProcessor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// <copyright file="ValidationInputTest.cs">Copyright ©  2019</copyright>

namespace DigitToWordsConverterLibrary.Tests
{
    /// <summary>This class contains parameterized unit tests for ValidationInput</summary>
    [TestClass]
    public class ValidationInputTest
    {

        /// <summary>
        /// Is Valid Input Test
        /// </summary>
        [TestMethod]
        public void IsValidInputTest()
        {
            ErrorCode result = ValidationInput.IsValidInput("dsds1000");
            Assert.AreEqual(ErrorCode.NotValid ,result);
        }

        /// <summary>
        /// InValid Long Integer Input Test
        /// </summary>
        [TestMethod]
        public void IsValidLongIntegerInputTest()
        {
            ErrorCode result = ValidationInput.IsValidInput("111111888888888888");
            Assert.AreEqual(ErrorCode.NotValid, result);
        }

        /// <summary>
        /// Valid Integer Input Test
        /// </summary>
        [TestMethod]
        public void ValidIntegerInputTest()
        {
            ErrorCode result = ValidationInput.IsValidInput("222225");
            Assert.AreEqual(ErrorCode.Valid, result);
        }
    }
}
