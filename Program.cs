using ElHogarLibros.ClienteBlazor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ElHogarLibros.ClienteBlazor.Services;

namespace ElHogarLibros.ClienteBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7080/api/") });
            builder.Services.AddScoped<IGradoService, GradoService>();
            builder.Services.AddScoped<IAlumnoService, AlumnoService>();

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://www.backend.com/api/") });

            builder.Services.AddMudServices();

            await builder.Build().RunAsync();
        }
    }
}

