using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.Interfaces
{
    public interface IMultilanguage<T>
    {
        T LanguageId { set; get; }
    }
}
