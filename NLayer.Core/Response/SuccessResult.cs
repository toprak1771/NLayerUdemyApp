﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Response
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        {
        }

        public SuccessResult(string message) : base(true, message)
        {
        }
    }
}
