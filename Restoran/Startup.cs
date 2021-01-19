using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Restoran.Database;
using Restoran.Model.Request;
using Restoran.Security;
using Restoran.Services;
using System.Data.SqlClient;
using System.Configuration;

namespace Restoran
{
    public class Startup
    {
   


        public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public IConfiguration Configuration { get; }

            // This method gets called by the runtime. Use this method to add services to the container.
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddControllers();
                services.AddAutoMapper(typeof(Startup));
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TheCodeBuzz-Service", Version = "v1" });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });

            });



            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BaseAuthenticationHandler>("BasicAuthentication", null);
            services.AddDbContext<eRestoranContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("eRestoran")));
           
            services.AddScoped<ICRUDService<Model.Artikal, ArtikalSearchRequest, ArtikalUpsertRequest, ArtikalUpsertRequest>, ArtikalService>();
            services.AddScoped<INarudzbaService, NarudzbaService>();
            services.AddScoped<ICRUDService<Model.StavkaNarudzbe, StavkeNarudzbeSearchRequest, object, object>, StavkeNarudzbeService>();
            services.AddScoped<ICRUDService<Model.JedinicaMjere, object, object, object>, BaseCRUDService < Model.JedinicaMjere, object,Database.JedinicaMjere, object, object>> ();
            services.AddScoped<ICRUDService<Model.Uloge, object, object, object>, BaseCRUDService < Model.Uloge, object,Database.Uloge, object, object>> ();
            services.AddScoped<ICRUDService<Model.KorisnikUloga, KorisnikUlogeSerachRequest, object, object>, KorisnikUlogeService> ();

            services.AddScoped<ICRUDService<Model.Kategorija, object, object, object>, BaseCRUDService<Restoran.Model.Kategorija, object, Kategorija, object, object>>();
            services.AddScoped<IZahtjevService, ZahtjevService>();
            services.AddScoped<ICRUDService<Model.Kombinacija, KombinacijaSearchRequest, KombinacijaUpsertRequest, KombinacijaUpsertRequest>,KombinacijaService>();
            services.AddScoped<ICRUDService<Model.Ponuda, PonudaSearchRequest, PonudaUpsertRequest, PonudaUpsertRequest>, PonudaService >();
            services.AddScoped<ICRUDService<Model.Meni, MeniSearchRequest, MeniUpsertRequest, MeniUpsertRequest>, MeniService>();
            services.AddScoped<ICRUDService<Model.StavkeMenija, StavkeMenijaSearchRequest, object, object>, StavkeMenijaService>();
            services.AddScoped<ICRUDService<Model.StavkeKombinacije, StavkeKombinacijeSearchRequest, StavkeKombinacijeUpsertRequest, StavkeKombinacijeUpsertRequest>,StavkeKombinacijeService>();
            //  services.AddScoped<ICRUDService<Restoran.Model.Korisnik, KorisniciSeachRequest, KorisniciUpsertReqests, KorisniciUpsertReqests>, BaseCRUDService<Restoran.Model.Korisnik, KorisniciSeachRequest, Korisnik, KorisniciUpsertReqests, KorisniciUpsertReqests>>();
            services.AddScoped<IKorisniciService, KorisnikService>();
            services.AddScoped<IKupacService, KupacService>();
            services.AddScoped<IPreporukaService, PreporukaService>();

            services.AddScoped<IStavkeZahtjevaService, StavkeZahtjevaService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TestService");
            });
            //  app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            }
        }
    }
