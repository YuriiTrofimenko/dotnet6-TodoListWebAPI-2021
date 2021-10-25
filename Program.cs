using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using TodoListWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddControllers();
    builder.Services.AddScoped<ITodosRepository, TodosInMemoryRepository>();
    builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy(
            /* name: MyAllowSpecificOrigins, */
            corsOptionsBuilder =>
            {
                corsOptionsBuilder.WithOrigins("http://localhost:4200")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
    });
    
    var app = builder.Build();

    // app.UseHttpsRedirection();

    app.UseRouting();

    app.UseCors(/* MyAllowSpecificOrigins */);
            
    app.UseAuthorization();

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
    
    app.Run();