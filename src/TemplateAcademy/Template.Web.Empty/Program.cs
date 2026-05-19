using Template.Core.Interfacce;
using Template.Web.Empty.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ISaluto, SalutoInItaliano>();
builder.Services.AddScoped<IClock, OrologioVero>();
builder.Services.AddScoped<IClock, OrologioMattutino>();


var app = builder.Build();


//IClock clock = new OrologioMattutino();
//ISaluto saluto = new SalutoInItaliano(clock);



//app.MapGet("/", (IClock clock) => {
//    //var data = DateTime.Now;
//    // return $"Ciao, mondo: {data.ToLongTimeString()}";
//    return $"Ciao mondo, {clock.GetNow().ToLongTimeString()} {clock.NumeroVisite}";
//});

app.MapGet("/", (ISaluto saluto) => {
    //var data = DateTime.Now;
    // return $"Ciao, mondo: {data.ToLongTimeString()}";
    return $"{saluto.GetSaluto()}";
});

app.MapGet("/saluto", (ISaluto saluto) => saluto.GetSaluto());



app.Run();
