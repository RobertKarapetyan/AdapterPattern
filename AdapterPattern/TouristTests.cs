using AdapterPattern.TouristClient;
using AdapterPattern.TranslatorAdapters;
using AdapterPattern.Translators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdapterPattern
{
    [TestClass]
    public class TouristTests
    {
        private  Tourist _tourist;
        private  FrenchTranslatorAdaptor _frenchTranslatorAdaptor;
        private  FrenchTranslator _frenchTranslator;
        private JapaneseTranslatorAdaptor _japaneseTranslatorAdaptor;
        private JapaneseTranslator _japaneseTranslator;
        
        [TestInitialize]
        public void TestInitialize()
        {
            _frenchTranslator = new FrenchTranslator();
            _frenchTranslatorAdaptor = new FrenchTranslatorAdaptor(_frenchTranslator);
            
            _japaneseTranslator = new JapaneseTranslator();
            _japaneseTranslatorAdaptor = new JapaneseTranslatorAdaptor(_japaneseTranslator);
            
            _tourist = new Tourist(_frenchTranslatorAdaptor);
        }
        
        [TestMethod]
        public void ShouldGreet()
        {
            _tourist.TranslatorTarget = _frenchTranslatorAdaptor;
            Assert.AreEqual(_frenchTranslator.Bonjour(), _tourist.Greetings());

            _tourist.TranslatorTarget = _japaneseTranslatorAdaptor;
            Assert.AreEqual(_japaneseTranslator.Konnichiwa(), _tourist.Greetings());
        }
    }
}