using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            } else
            {
                // Reveal 404 Page
            }
            
            app.UseNodeModules();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints( cfg =>
            {
                cfg.MapControllerRoute("Default",
                    "{controller}/{action}/{id?}",
                    new { controller = "Home", action = "index" });
            });
        }
    }
}

//Convert the Web App you created in Assignment #1 to an MVC structure following the pattern in this week's videos.  Separate your Grade Calculator program into a second view and add navigation to access that page.  Create a model for your Grade Calculation form.

//Be sure to include:

//The basic jQuery selector ($) to select the elements in your JavaScript program.
//Appropriate folders for each element of MVC.
//A Controller to access the corresponding Views.
//Razor code to set the text in the header.
//A shared layout across all pages.
//Tag helpers for navigation.
//Validation in the model to ensure the user enters a number between 0 and 100 (#notcoveredinthevideos).
//As always, write good code (use indentation, commenting, whitespace, descriptive variable names, etc.)

//Submit a link to the GitHub Repository containing your project.  Alternatively, you can zip the project folder up and upload that .zip file.
