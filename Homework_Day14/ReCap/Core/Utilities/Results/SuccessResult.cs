using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message) // mesaj varsa base'e true ve message yolluyoruz
        {
            
        }
        public SuccessResult() : base(true) // mesaj verilmediğinde base'e sadece true gönderiyoruz
        {
            
        }

    }
}
