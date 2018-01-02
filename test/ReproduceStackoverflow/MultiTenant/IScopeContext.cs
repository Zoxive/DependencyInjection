using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ReproduceStackoverflow.App.MultiTenant
{
    public interface IScopeContext
    {
        IDictionary<string, object> Items { get; }
    }

    public class ScopeContext : IScopeContext, IDisposable
    {
        public ScopeContext()
        {
            Items = new ConcurrentDictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        }

        public IDictionary<string, object> Items { get; private set; }

        public void Dispose()
        {
            Items = null;
        }
    }
}