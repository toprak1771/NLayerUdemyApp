using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Response
{
    public class Result : IResult
    {
        public bool IsSuccess { get; }

        public string Message { get; set; }

        public Result(bool Issuccess)
        {
            IsSuccess= Issuccess;   
        }

        public Result(bool Issuccess, string? message) : this(Issuccess)
        {
            Message = message;
        }
    }
}
