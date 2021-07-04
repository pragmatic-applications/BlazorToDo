using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Domain;

using Interfaces;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace To_Do
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<ToDoItem>();
            builder.Services.AddScoped<List<ToDoItem>>();

            //builder.Services.AddScoped<ITaskService, ToDoItemService>();
            builder.Services.AddScoped<ITaskService<ToDoItem>, ToDoItemService>();

            await builder.Build().RunAsync();
        }
    }
}
