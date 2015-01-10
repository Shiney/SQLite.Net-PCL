using JetBrains.Annotations;

namespace SQLite.Net
{
    [PublicAPI]
    public interface ITraceListener
    {
        void Receive(string message);
    }
}