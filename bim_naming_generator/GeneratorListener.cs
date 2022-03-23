namespace bim_naming_generator
{
    internal interface GeneratorListener
    {
        void OnGenerateResult(string newNumber, bool result);
    }
}