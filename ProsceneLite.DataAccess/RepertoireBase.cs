using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Linq;
using System.Collections.Concurrent;

namespace ProsceneLite.DataAccess
{
    public class RepertoireBase<T>:IDisposable where T:DbContext
    {
        bool disposed = false;
        private readonly DbContextOptions<T> _options;
        private readonly ConcurrentBag<IDisposable> _disposables = new ConcurrentBag<IDisposable>();
        private static readonly ConstructorInfo _ctor;

        static RepertoireBase()
        {
            _ctor = typeof(T).GetConstructor(new[] { typeof(DbContextOptions<T>) });        
        }

        protected RepertoireBase(DbContextOptions<T> options)
        {
            _options = options ?? throw new ArgumentNullException(nameof(DbContextOptions));
        }

        void IDisposable.Dispose()
        {
            //Dispose of unmanaged resources
            Dispose(true);
            //suppress finalization
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if(disposing)
            {
                disposed = true;
                _disposables
                    .ToList()
                    .ForEach(d => d.Dispose());
            }
        }

        protected T CreateContext()
        {
            var ctx = _ctor.Invoke(new[] { _options }) as T;
            _disposables.Add(ctx);
            return ctx as T;
        }
    }
}
