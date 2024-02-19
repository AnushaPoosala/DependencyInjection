using DependencyInjection.Repositories;

var builder = WebApplication.CreateBuilder(args);
//1.we will write all services(using builder) first then we will go for (app)
builder.Services.AddMvc();

//2.add application services(2 types application services, framework services(IOC -Inversion of Control) for Dependency Injection) 

builder.Services.AddTransient<IBankRepository,BankRepository>(); 
builder.Services.AddTransient<ITestBankRepo,TestBankRepo>();
//a singleton service is created only once per application life time. We will use the same instance through out the application whenever irt is required. Ex(logging).It should be thread safe.

//builder.Services.AddTransient<IBankRepository, BankRepository>();
//a transient sevice is created each time it is requested from the service container(IOC/DI). Which meeans it will create the instance for every class/method when it is required. Ex:frequently changoing data(stockMarket). stores light weight data. No need of thread safety.

//builder.Services.AddScoped<IBankRepository, BankRepository>();//

//builder.Services.AddSingleton<IBankRepository, BankRepository>();
//a singleton service is created only once per application life time. We will use the same instance through out the application whenever irt is required. Ex(logging).It should be thread safe.

//builder.Services.AddTransient<IBankRepository, BankRepository>();
//a transient sevice is created each time it is requested from the service container(IOC/DI). Which meeans it will create the instance for every class/method when it is required. Ex:frequently changoing data(stockMarket). stores light weight data. No need of thread safety.

//builder.Services.AddScoped<IBankRepository, BankRepository>();//

//a scoped service is created once for client request(HTTP get/Post). we need to use this Scoped to maintain state with in the single request. We dont need to share the data across the different requests.
//when we are using the above 3  types of Life times in DI, built in IOC container manages the lifetime of registered service.

var app = builder.Build();

//3.Adding Routing
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.MapGet("/", () => "Hello World!");

app.Run();

