using System;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Client.Componets
{
    public partial class LoaderComponent
    {
        [Parameter]
        public bool IsLoading { get; set; }
        [Parameter]
        public RenderFragment Loading { get; set; }
        [Parameter]
        public RenderFragment Content { get; set; }
    }
}