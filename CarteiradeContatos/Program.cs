using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var env = builder.Environment;

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorPages();
builder.Services.AddAuthorization();
builder.Services.AddSignalR();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapBlazorHub(); // Adicione esta linha para Blazor
app.MapFallbackToPage("/_Host"); // Adicione esta linha para Blazor

app.MapRazorPages();
app.Run();