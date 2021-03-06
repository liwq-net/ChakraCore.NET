﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChakraCore.NET
{

    public class ServiceNotRegisteredException<T> : Exception
    {
        public ServiceNotRegisteredException() : base($"service type {typeof(T).ToString()} not registered") 
            { }
    }
}
