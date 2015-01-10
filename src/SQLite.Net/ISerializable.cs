using System;
using JetBrains.Annotations;

namespace SQLite.Net
{
    [PublicAPI]
    public interface ISerializable<T>
    {
        T Serialize();
    }
}

