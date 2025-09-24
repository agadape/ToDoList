using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ToDo_List.Shared.Services;
using ToDo_List.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the ToDo_List.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
