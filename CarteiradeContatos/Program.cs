var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServerSideBlazor(options =>
{
    options.DetailedErrors = true;
});
builder.Services.AddScoped<CustomCircuitHandler>();
builder.Services.AddSingleton<ContatoService>();
builder.Services.AddSignalR();
builder.Services.AddAntiforgery();
builder.Services.AddScoped<Microsoft.AspNetCore.Components.Server.Circuits.CircuitRegistry>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
