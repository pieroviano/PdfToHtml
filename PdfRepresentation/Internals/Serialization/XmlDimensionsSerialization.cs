using CoreLibrary.Configuration.Hosting;

namespace PdfRepresentation.Serialization
{
    internal static class XmlDimensionsSerialization
    {
        public static bool ShouldSerializeDimensions
        {
            get
            {
                var argumentGetter = ArgumentGetterHost<string>.Instance.ArgumentGetter;
                return argumentGetter?.BooleanFromArguments["ShouldSerializeDimensions", true] ?? false;
            }
            set
            {
                var argumentGetter = ArgumentGetterHost<string>.Instance.ArgumentGetter;
                if (argumentGetter != null)
                {
                    argumentGetter.BooleanFromArguments["ShouldSerializeDimensions"] = value;
                }
            }
        }
    }
}