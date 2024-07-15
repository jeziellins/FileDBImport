using FileDBImport.Worker;
using FileDBImport.Worker.Data;
using FileDBImport.Worker.Data.Repositories;
using FileDBImport.Worker.Data.Repositories.Interfaces;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddTransient<IInstrumentsRepository, InstrumentsRepository>();
builder.Services.AddData();
builder.Services.AddHostedService<Worker>();


var host = builder.Build();
host.Run();
