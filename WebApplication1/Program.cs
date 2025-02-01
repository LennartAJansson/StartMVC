using WebApplication1.Abstract;
using WebApplication1.Services;
using Refit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IFriendsService, FriendsService>();
builder.Services.AddRefitClient<IFriendsApiClient>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:5001"));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
