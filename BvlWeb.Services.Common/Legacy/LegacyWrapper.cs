namespace BvlWeb.Services.Common.Legacy
{
    public class LegacyWrapper
    {
        // Simulate a call to a legacy C++ service.
        public string CallLegacyService(string parameter)
        {
            // In reality, this might use P/Invoke, COM, or other interop methods.
            return $"Legacy response for {parameter}";
        }
    }
}
