using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.Interfaces
{
    public interface IHasOwner<T>
    {

        T OwnerId { set; get; } 
    }
}
