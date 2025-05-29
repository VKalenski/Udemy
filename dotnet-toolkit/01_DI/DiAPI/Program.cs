#region Usings
using DiAPi.Data;
using DiAPi.DataServices;
using DiAPi.Middleware;
using DiAPi.Utility;
#endregion

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IDataRepo, NoSqlDataRepo>();
builder.Services.AddScoped<IDataService, HttpDataService>();

builder.Services.AddTransient<IOperationTransient, Operation>();
builder.Services.AddScoped<IOperationScoped, Operation>();
builder.Services.AddSingleton<IOperationSingleton, Operation>();

var app = builder.Build();

app.UseCustomMiddleware();

app.UseHttpsRedirection();

app.MapGet("/getdata", (IOperationTransient transient, IOperationScoped scoped, IOperationSingleton singleton) =>
{
    // var repo = new SqlDataRepo();
    // var repo = new NoSqlDataRepo();

    // repo.ReturnData();

    Console.WriteLine($"Endpoint: TransientId: {transient.OperationId} ScopedId: {scoped.OperationId} SingletonId {singleton.OperationId}");
    return Results.Ok();
});


app.Run();