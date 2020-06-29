using System;
using System.Linq;
using System.Net.Http;
using BlazorDemo.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorDemo.Client.Componets
{
    public partial class UserCard
    {
        [Inject]
        public IJSRuntime Runtime { get; set; }
        [Parameter]
        public User User { get; set; }
        private async void Delete(User user)
        {
            var data = await Runtime.InvokeAsync<object>("confirm", null);
        }
    }
}