using System;
#if SSHARP
using Crestron.SimplSharp.Reflection;
#else
using System.Reflection;
#endif

namespace Lextm.SharpSnmpLib.Pipeline
{
    /// <summary>
    /// Default type resolver to return default type.
    /// </summary>
    public class DefaultTypeResolver : ITypeResolver
    {
        /// <inheritdoc />
        public Type Load(string assembly, string name)
        {
            // IMPORTANT: .NET standard 1.3 does not support this scenario so simply return a default type.
            return typeof(NullMessageHandler);
        }

        /// <inheritdoc />
        public Assembly[] GetAssemblies()
        {
#if SSHARP
            return ArrayEx.Empty<Assembly>();
#else
            return Array.Empty<Assembly>();
#endif
        }
    }
}