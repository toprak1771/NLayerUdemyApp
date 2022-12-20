using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Response
{
    public class ErrorDataResult<TData> : DataResult<TData>
    {
        public ErrorDataResult() : base(default,false)
        {

        }
        public ErrorDataResult(TData data) : base(data, false)
        {
        }

        public ErrorDataResult(string message) : base(false, message)
        {
        }

        public ErrorDataResult(TData data, string message) : base(data, false, message)
        {
        }
    }
}
