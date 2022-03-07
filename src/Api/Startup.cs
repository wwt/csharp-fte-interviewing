using Data;

namespace Api;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc(options => options.EnableEndpointRouting = false);
        services
            .AddHttpContextAccessor()
            .LoadDatabase()
            .AddAuthorization()
            .AddSwaggerGen(
                c =>
                    c.SwaggerDoc(
                        "v1",
                        new Microsoft.OpenApi.Models.OpenApiInfo
                        {
                            Title = "My API",
                            Version = "v1"
                        }
                    )
            )
            .AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHsts();
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}
