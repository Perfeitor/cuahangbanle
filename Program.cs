using MudBlazor.Services;
using cuahangbanle.Components;
using cuahangbanle.DBData.Context;
using Microsoft.EntityFrameworkCore;
using cuahangbanle.DBData.Services;
using MudBlazor.Translations;

var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//Kết nối database
builder.Services.AddDbContext<DBContext>(options => options.UseSqlServer(builder.Configuration?.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Không tồn tại chuỗi kết nối")));

//Bản địa hoá
builder.Services.AddMudTranslations();

//Đăng ký dịch vụ
builder.Services.AddScoped<IDonvitinhService, DonvitinhService>();
builder.Services.AddScoped<IMathangService, MathangService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
