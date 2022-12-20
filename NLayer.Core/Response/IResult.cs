﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Response
{
    public interface IResult
    {
        bool IsSuccess { get; } 
        string Message { get; set; }
    }
}
