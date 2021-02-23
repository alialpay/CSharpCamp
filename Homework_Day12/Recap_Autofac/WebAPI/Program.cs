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
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())     // Bu ve altýndaki açýklamalý satýrlarý þak diye zaten yazamayýz. Autofac için yazdýðýmýz AutofacBusinessModule 
                .ConfigureContainer<ContainerBuilder>(builder =>                    // classýndaki þartlarýmýzý kullanmak için IoC container dökümantasyonundan faydalandýk.
                {                                                                   // Yani burasý ben .NetCore yerine kendi IoC Conteiner'ýmý kullanmak istiyorum demek.
                    builder.RegisterModule(new AutofacBusinessModule());            // WebApý altýndaki StartUp'da uygulamak yerine sürdürülebilirlik için Autofac özelinde
                })                                                                  // bir uygulama yapmýþ olduk
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
