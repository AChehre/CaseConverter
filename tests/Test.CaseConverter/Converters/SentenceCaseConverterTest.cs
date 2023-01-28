using CaseConverter.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.CaseConverter.Converters
{
    /// <summary>
    /// <see cref="SentenceCaseConverter"/>のテストクラスです。
    /// </summary>
    [TestClass]
    public class SentenceCaseConverterTest : CaseConverterTestBase<SentenceCaseConverter>
    {
        [TestMethod]
        public void ConvertTest()
        {
            ConvertTest("Hoge fuga piyo", "Hoge", "H");
        }
    }
}
