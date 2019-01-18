using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace SquaredUp.Dashboard.Schema.Validator
{
    public interface ITileConfigParser
    {
        dynamic Parse<T>(string originalType, Value v, ResultInfo result) where T : IMessage, new();
    }
}
