using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class ErrorResult:Result,IResults
    {
        public  ErrorResult(bool success,string message):base(false,message)
        {
                
        }
        public ErrorResult(string message):base(false,message)
        {
                
        }
    }
}
