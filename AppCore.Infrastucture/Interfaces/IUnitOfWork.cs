using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Infrastucture.Interfaces
{
    /// <summary>
    /// Call save change from dbcontext
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        void commit();
    }
}
