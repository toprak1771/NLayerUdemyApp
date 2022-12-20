using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Response
{
    public class DataResult<TData> : Result, IDataResult<TData>
    {
        public DataResult(TData? data,bool Issuccess) : base(Issuccess)
        {
            Data = data;
        }

        public DataResult(bool Issuccess, string? message) : base(Issuccess, message)
        {
        }

        public DataResult(TData? data,bool Issuccess, string? message) : base(Issuccess, message)
        {
            Data = data;
        }


        public TData? Data { get; set; }

       
    }
}
