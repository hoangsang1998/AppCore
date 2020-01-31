using System;

namespace AppCore.Data.Interfaces
{
    public interface IDateTracking
    {

        DateTime DateCreated { set; get; }

        DateTime DateModyfied { set; get; }
    }
}