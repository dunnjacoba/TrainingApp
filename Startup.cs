using Microsoft.AspNetCore.Builder;
using System;
using TrainingApp.Services;

public class Startup
{
	public Startup(IConfiguration configuration)
	{
		Configuration = configuration;
	}
	public IConfiguration Configuration { get; }

	public void ConfigureServices(IServiceCollection services)
	{
		services.AddAuthorization();
		// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
		services.AddControllers();
		services.AddSwaggerGen();
		services.AddTransient<EmployeeService>();
	}

	public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
	{
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
		app.UseStaticFiles();

		app.UseRouting();
		app.UseCors();

		app.UseAuthorization();

        app.UseEndpoints(endpoints =>
		{
			endpoints.MapControllers();
		});
		
		

        // Configure the HTTP request pipeline.

    }
}








