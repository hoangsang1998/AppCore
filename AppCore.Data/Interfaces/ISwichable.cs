using AppCore.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.Interfaces
{
    public interface ISwichable
    {
        Status Status { set; get; }
    }
}
