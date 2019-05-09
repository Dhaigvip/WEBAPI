
using CommonCore.Tcm.Common.Tcm.Logger;
using CommonCore.Tcm.Common.UnityContainer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using TCM.Web.API.Core.ExceptionHandler;
using TCM.Web.API.Core.Helpers;
using TCM.Web.Business;
using Unity;

namespace TCM.Web.API.Core
{
    public class Startup
    {
        private AppSettings appSettings;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            var appSettingsSection = Configuration.GetSection("AppSettings");

            // configure jwt authentication
            appSettings = appSettingsSection.Get<AppSettings>();
        }

        public static IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Init unity containers
            //TCMWebApp.Init();

            //var identityUrl = Configuration.GetValue<string>("IdentityUrl");
            //var authenticationProviderKey = "IdentityApiKey";

            //services.AddHealthChecks()
            //  .AddCheck("self", () => HealthCheckResult.Healthy());


            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            var allowedOrigins = Configuration.GetSection("AllowedOrigins").Get<List<string>>();



            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    .WithOrigins(allowedOrigins.ToArray()));
            });

           

            services.AddSingleton<IAuthenticate, ExternalAutheticationService>();

            services.AddAuthentication(TCMAuthenticationDefaults.AuthenticationScheme)
                .AddTCMAuthetication(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key)
                    };
                    x.Events = new JwtBearerEvents()
                    {
                        OnAuthenticationFailed = async ctx =>
                        {
                            int i = 0;
                        },
                        OnTokenValidated = async ctx =>
                        {
                            int i = 0;
                        },

                        OnMessageReceived = async ctx =>
                        {
                            int i = 0;
                        }
                    };
                });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "TCM.Web.API.Core", Version = "v1" });
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });



            services.AddMvc(options =>
            {
                //ContentResult negotiation
                options.RespectBrowserAcceptHeader = true;
            })

            //else all properties are lower cased...
            .AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //services.AddSignalR();

            //    .AddJsonProtocol(options =>
            //{
            //    options.PayloadSerializerSettings.ContractResolver =
            //    new DefaultContractResolver();
            //}).AddHubOptions<DashboardQueryHub>(x =>
            //{
            //    // TO DO :
            //});

            services.AddOcelot(Configuration);



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            app.Handle_OPTIONS_Request();
            app.UseCors("CorsPolicy");
            AutoMapper.Mapper.Initialize(cfg => DomainEntityProxyMapper.RegisterDomainEntityProxyMapping(cfg));

            app.UseDefaultFiles();
            app.UseStaticFiles();


            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TCM.Web.API.Core");
            });

            app.UseMiddleware<GlobalExceptionHandler>();
            app.UseMvc();
            //app.UseSignalR(routes =>
            //{
            //    routes.MapHub<TestHub>("/hub");
            //});
            app.UseOcelot().Wait();
           
        }


        public void ConfigureContainer(IUnityContainer container)
        {
            UnityHelper.Container =
                UnityContainerSetUp.Configure(container, "Common");
            var log = container.Resolve<ILogger>();

            //if (appSettings.LoadFlightControl)
            //{
            //    var fcFactory = new FlightControlFactory(container);
            //    fcFactory.Defaults.NameEditor = s => s;

            //    fcFactory
            //        .AddConsumer<DashboarQueryConsumer>("DashboarQueryConsumer")
            //        .AddMsmqEndPoint("XfmClientQueue")
            //        .AddMsmqEndPoint("DashboardGwQueue", FlightControlFactory.MockUp.Yes);

            //    var flightControl = fcFactory.CreateFlightControl();
            //    flightControl.
            //        ReplaceTypeName("DashboardMessage.DashboardData, DashboardMessage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")
            //       .With(typeof(DashboardMessage.DashboardData));

            //    flightControl.IsLogIncommingMessages = true;
            //}
        }
    }
}
