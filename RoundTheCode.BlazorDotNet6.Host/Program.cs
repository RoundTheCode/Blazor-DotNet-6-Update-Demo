var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseWebAssemblyDebugging();
}

app.UseBlazorFrameworkFiles();
app.MapRazorPages();
app.UseStaticFiles();
app.UseRouting();
app.MapFallbackToPage("/_Host");

app.Run();
