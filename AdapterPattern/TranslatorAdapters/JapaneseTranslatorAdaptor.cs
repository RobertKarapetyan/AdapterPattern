using AdapterPattern.TouristClient;
using AdapterPattern.Translators;

namespace AdapterPattern.TranslatorAdapters
{
    public class JapaneseTranslatorAdaptor : ITranslatorTarget
    {
        private readonly JapaneseTranslator _japaneseTranslator;

        public JapaneseTranslatorAdaptor(JapaneseTranslator japaneseTranslator)
        {
            this._japaneseTranslator = japaneseTranslator;
        }

        public string Greetings()
        {
            return _japaneseTranslator.Konnichiwa();
        }
    }
}