using MudBlazor.Services;
using cuahangbanle.Components;
using cuahangbanle.DBData.Context;
using Microsoft.EntityFrameworkCore;
using cuahangbanle.DBData.Services;
using MudBlazor.Translations;
using cuahangbanle.DBData.Seed;

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
builder.Services.AddScoped<INhacungcapService, NhacungcapService>();
builder.Services.AddScoped<INganhhangService, NganhhangService>();
builder.Services.AddScoped<INhomquyenServicecs, NhomquyenService>();
builder.Services.AddScoped<IDonhangService, DonhangService>();
builder.Services.AddScoped<ITaikhoanService, TaikhoanService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Đảm bảo cơ sở dữ liệu được tạo và seed dữ liệu
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DBContext>();
    dbContext.Database.EnsureCreated();
    await SeedData.Seed(dbContext);
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
