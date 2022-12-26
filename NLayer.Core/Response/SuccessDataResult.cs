using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Response
{
    public class SuccessDataResult<TData> : DataResult<TData>
    {
            
        

        public SuccessDataResult(string message) : base(true, message)
        {
        }

        public SuccessDataResult(TData data, string? message) : base(data, true, message)
        {
        }

    }
}
