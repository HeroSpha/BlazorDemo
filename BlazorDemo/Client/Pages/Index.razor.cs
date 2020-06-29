using BlazorDemo.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorDemo.Client.Pages
{
    public partial class Index
    {
        [Inject]
        public HttpClient  Http { get; set; }
        private List<User> Users { get; set; }

        public Index()
        {
            Users = new List<User>();
        }
        protected async override Task OnInitializedAsync()
        {
            Users = new List<User>(await Http.GetFromJsonAsync<List<User>>("api/users/getusers"));
        }
    }
}
