using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DigitalMatterPracticalExercise.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<AdminContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AdminContext") ?? throw new InvalidOperationException("Connection string 'AdminContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<AdminContext>();
    DataSeed.PopulateDatabase(context);
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
