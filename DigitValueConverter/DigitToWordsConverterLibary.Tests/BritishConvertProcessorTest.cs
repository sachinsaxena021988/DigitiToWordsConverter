// <copyright file="BritishConvertProcessorTest.cs">Copyright ©  2019</copyright>

using DigitToWordsConverter.ConverterProcessor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared;
using Shared.Logging;

namespace DigitToWordsConverterLibrary.Tests
{
   
    [TestClass]
    public class BritishConvertProcessorTest :Base
    {
        private IConverterProcessor _processor;

        [TestInitialize]
        public void InitializeClass()
        {
            ILogger logger =new ConsoleLogger();
            _processor =new BritishConvertProcessor(logger);
        }

        [TestMethod]
        public void InputOneDigitValue()
        {
            Assert.AreEqual(_processor.ConvertDigitToString(1), one);
        }

        [TestMethod]
        public void InputTwoDigitValue()
        {
            Assert.AreEqual(_processor.ConvertDigitToString(21), twentyOne);
        }

        [TestMethod]
        public void InputHundredValue()
        {
            Assert.AreEqual(_processor.ConvertDigitToString(105), onehundredFive);
        }

        [TestMethod]
        public void InputThousandValue()
        {
            Assert.AreEqual(_processor.ConvertDigitToString(1105), thousandValue);
        }

        [TestMethod]
        public void InputMillionValue()
        {
            Assert.AreEqual(_processor.ConvertDigitToString(56945781), millionValue);
        }

    }
}
