namespace AdapterPattern.TouristClient
{
    public class Tourist : ITourist
    {
        public ITranslatorTarget TranslatorTarget;

        public Tourist(ITranslatorTarget translatorTarget)
        {
            this.TranslatorTarget = translatorTarget;
        }

        public string Greetings()
        {
            return TranslatorTarget.Greetings();
        }
    }
}