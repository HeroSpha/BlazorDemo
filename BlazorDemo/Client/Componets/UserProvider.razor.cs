using System;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Client.Componets
{
    public partial class UserProvider
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        public int Counter { get; set; }
        public void SetCounter(int counter)
        {
            Counter = counter;
        }
    }
}