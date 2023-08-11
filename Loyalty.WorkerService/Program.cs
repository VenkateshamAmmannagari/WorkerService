using Hangfire;
using Loyalty.WorkerService;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddHangfire(configuration =>
        {
            configuration.UseSqlServerStorage("Data Source = LTPHYD052474305\\SQLEXPRESS; Initial Catalog=MPHASIS; Integrated Security = True;TrustServerCertificate=True");
        });
    })
    .Build();

await host.RunAsync();
