using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.Autofac;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())     // Bu ve alt�ndaki a��klamal� sat�rlar� �ak diye zaten yazamay�z. Autofac i�in yazd���m�z AutofacBusinessModule 
                .ConfigureContainer<ContainerBuilder>(builder =>                    // class�ndaki �artlar�m�z� kullanmak i�in IoC container d�k�mantasyonundan faydaland�k.
                {                                                                   // Yani buras� ben .NetCore yerine kendi IoC Conteiner'�m� kullanmak istiyorum demek.
                    builder.RegisterModule(new AutofacBusinessModule());            // WebAp� alt�ndaki StartUp'da uygulamak yerine s�rd�r�lebilirlik i�in Autofac �zelinde
                })                                                                  // bir uygulama yapm�� olduk
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
