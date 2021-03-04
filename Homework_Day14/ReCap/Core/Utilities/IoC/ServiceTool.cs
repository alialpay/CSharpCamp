using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public static class ServiceTool
    {   // bu servicetool'u kullanarak dependencyleri yakalayabiliyoruz.
        // kısacası bu kod webapi'de veya autofac'de oluşturduğumuz injectionları oluşturabilmemize yarıyor. bundan böyle istediğimiz herhangi bir interface'in servisdeki karşılığını bu tool vasıtasıyla alabiliriz
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)            // .Net'in IServiceCollection'ını kullanarak servislerini al
        {
            ServiceProvider = services.BuildServiceProvider();                          // ve onları build et
            return services;
        }
    }
}
