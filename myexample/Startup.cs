using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace myexample
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {


      // Add framework services.
      services.AddMvc();

      services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
      {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
      }));
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
    {
      loggerFactory.AddConsole();

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseBrowserLink();
      }

      app.UseDefaultFiles();
      app.UseStaticFiles();
      app.UseMvcWithDefaultRoute();

      app.UseCors("MyPolicy");
    }
  }

}
