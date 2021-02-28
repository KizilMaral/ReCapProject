using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public interface IResults
    {
         string Message { get; }
         bool Success { get; }
    }
}
