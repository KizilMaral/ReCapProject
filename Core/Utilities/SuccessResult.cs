using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class SuccessResult:Result,IResults
    {
        public SuccessResult(bool success,string message):base(true,message)
        {

        }
        public SuccessResult(string message):base(true,message)
        {
                
        }
    }
}
