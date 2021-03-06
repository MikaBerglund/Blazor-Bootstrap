﻿using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components.JSInterop
{
    public abstract class ComponentInteropBase
    {
        protected ComponentInteropBase(IJSRuntime interopRuntime)
        {
            this.InteropRuntime = interopRuntime;
        }

        public IJSRuntime InteropRuntime { get; private set; }

    }
}
