var builder = WebApplication.CreateBuilder(args);

// 1. Agrega el servicio para soportar Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// 2. Configura el pipeline para manejar errores y HTTPS
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// 3. Habilita el uso de archivos estáticos (wwwroot: CSS, JS, imágenes)
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// 4. Mapea las rutas a las Razor Pages
app.MapRazorPages();

app.Run();
