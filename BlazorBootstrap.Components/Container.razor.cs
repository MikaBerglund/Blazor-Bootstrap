﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBootstrap.Components
{
    partial class Container
    {
        public Container()
        {
            this.Type = ContainerType.FixedWidth;
        }

        [Parameter]
        public ContainerType Type { get; set; }


        protected override void OnParametersSet()
        {
            if(this.Type == ContainerType.FixedWidth)
            {
                this.AddClass(ClassNames.Containers.FixedWidth);
            }
            else
            {
                this.AddClass($"{ClassNames.Containers.FixedWidth}-{this.Type.ToString().ToLower()}");
            }

            base.OnParametersSet();
        }
    }
}
