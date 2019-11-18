using BFICommon.Core.GlobalErrorHandling;
﻿using AutoMapper;
using BFICommon.Util.NamingConvention;
using Legacy.API.APIServer.Utilities.AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace Legacy.API.APIServer
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors();

            var mappingConfig = new MapperConfiguration(mc =>
            {
#pragma warning disable CS0618 // Type or member is obsolete
                mc.CreateMissingTypeMaps = true;
#pragma warning restore CS0618 // Type or member is obsolete
                mc.AddMaps(new[] {
                    "Legacy.API.APIServer"
                });
                mc.ValidateInlineMaps = false;
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);




            services.TryAddEnumerable(ServiceDescriptor
               .Transient<IApiDescriptionProvider, SnakeCaseQueryParametersApiDescriptionProvider>());

            services.AddMvc(ops =>
            {
                ops.ValueProviderFactories.Add(new SnakeCaseQueryValueProviderFactory());
                ops.Filters.Add<ActionFilterException>();
            })
            .AddJsonOptions(x =>
            {
                x.SerializerSettings.ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                };
            });

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            
            AutoMapperConfiguration.Configure();

            services.AddSwaggerGen(c =>
            {
                //The generated Swagger JSON file will have these properties.
                c.SwaggerDoc("v1", new Info
                {
                    Title = "Swagger API Legacy Documentation",
                    Version = "v1",
                });

                //...tell Swagger to use those XML comments.
                foreach (var name in Directory.GetFiles("SwaggerXML", "*.XML", SearchOption.AllDirectories))
                {
                    c.IncludeXmlComments(filePath: name);
                }
                c.EnableAnnotations();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseSwagger();

            //This line enables Swagger UI, which provides us with a nice, simple UI with which we can view our API calls.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "Swagger API Legacy Documentation v1");
            });

            app.ConfigureExceptionHandler();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
