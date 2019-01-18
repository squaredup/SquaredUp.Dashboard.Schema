using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace SquaredUp.Dashboard.Schema.Validator
{
    /// <summary>
    /// Tile parser which requires absolute schema conformance otherwise it errors
    /// </summary>
    public class ConformanceTileParser : ITileConfigParser
    {
        private readonly JsonParser _strictParser =
            new JsonParser(
                new JsonParser.Settings(JsonParser.Settings.Default.RecursionLimit));

        public dynamic Parse<T>(string originalType, Value v, ResultInfo result) where T : IMessage, new()
        {
            return _strictParser.Parse<T>(v.StructValue.ToString());
        }
    }
}
