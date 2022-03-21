namespace bim_naming_generator
{
    internal interface GeneratorListener
    {
        void OnGeneratedSuccess(string newNumber);
        void OnGeneratedFailure(string error);
    }
}