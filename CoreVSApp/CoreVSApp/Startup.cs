using CoreVSApp.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreVSApp
{
    public class Startup
    {
        IWebHostEnvironment _env;

        public Startup(IWebHostEnvironment env)
        {
            _env = env;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        /// <summary>
        ///  ���������� ��� �������� About
        /// </summary>
        private void About(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync($"{_env.ApplicationName} - ASP.Net Core tutorial project");
            });
        }

        /// <summary>
        ///  ���������� ��� �������� Config
        /// </summary>
        private void Config(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync($"App name: {_env.ApplicationName}. App running configuration: {_env.EnvironmentName}");
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() || env.IsStaging())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // ������������ ������ HTTP
            app.UseStatusCodePages();

            // ��������� ����������� ������
            app.UseStaticFiles();

            // ���������� ����������� � �������������� �� �������������� ����
            app.UseMiddleware<LoggingMiddleware>();

            Console.WriteLine($"Launching project from: {_env.ContentRootPath}");

            //��������� ��������� � ���������� ��������� ��� ������� ��������
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync($"Welcome to the {_env.ApplicationName}!");
                });
            });

            // ��� ������ �������� ����� ��������� �����������
            app.Map("/about", About);
            app.Map("/config", Config);

            //// ���������� ��� ������ "�������� �� �������"
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync($"Page not found");
            //});

        }



        
    }
}
