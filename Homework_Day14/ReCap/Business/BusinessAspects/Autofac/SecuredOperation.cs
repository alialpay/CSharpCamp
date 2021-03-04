using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Core.Extensions;
using Business.Constants;

namespace Business.BusinessAspects.Autofac
{
    //JWT için
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;              // her istek için bir httpcontext oluşur

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');                                                                  // belirttiğimiz "," karektörüne göre ayırıp rolleri bir array'e atıyor
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();      // servistool bizim injection altyapımızı aynen okumamızı sağlayan bir araç. 
                                                                                                        // peki bu ne işe yarıyor? : jwthelper'da configurationu rahatça enjekte edebilmiştik, fakat securedoperation bir aspect olduğundan enjekte edemiyoruz. o yüzden bizim autofac ile oluşturduğumuz servis mimarimize ulaş(getservice) ve injection değerlerini al
                                                                                                        // örneğin productService = ServiceTool.ServiceProvider.GetService<IProductService>(); yaptığımızda bu gidip bizim autofacte yaptığımız injection değerleri alabilecek
        }                                                                                               // burada bir altyapıya ihtiyacımız var. Solution --> Manage NuGet Packages -->Autofac.Extensions.DependencyInjection(DynamicProxy) ve Business --> Microsoft.Extensions.DependencyInjection. visual studio saçmaladı usingleri el ile ekledik

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
