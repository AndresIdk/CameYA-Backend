﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameYA.Core.Exceptions
{
    public class BusinessException : Exception
    {
        public BusinessException() { }
        public BusinessException(string msg) : base(msg)
        {
            
        }
    }
}
