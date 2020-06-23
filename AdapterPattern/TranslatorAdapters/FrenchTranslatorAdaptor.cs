using AdapterPattern.TouristClient;
using AdapterPattern.Translators;

namespace AdapterPattern.TranslatorAdapters
{
    public class FrenchTranslatorAdaptor : ITranslatorTarget
    {
        private readonly FrenchTranslator _frenchTranslator;

        public FrenchTranslatorAdaptor(FrenchTranslator frenchTranslator)
        {
            this._frenchTranslator = frenchTranslator;
        }

        public string Greetings()
        {
            return _frenchTranslator.Bonjour();
        }
    }
}