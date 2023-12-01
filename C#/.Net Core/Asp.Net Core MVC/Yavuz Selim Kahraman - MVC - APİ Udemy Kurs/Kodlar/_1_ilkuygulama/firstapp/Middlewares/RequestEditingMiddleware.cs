using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;

namespace firstapp.Middlewares
{
    public class RequestEditingMiddleware
    {
        // Dependency injection ile inject olacaktır. 
        private readonly RequestDelegate _requestDelegate;
        public RequestEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        // Bir Middleware i kullanabilmemiz için bir adet method gerekecektir. Middleware yazım süreçlerinde mecvuri tanımlama gerektirmektedir. 

        // Request Ve Responselara erişebilmemiz için HttpContext içerisinden erişim gerekeceğinden kaynaklı olarak bizler invoke methodu içerisinde HttpContext instance i yazdık 
        public async Task Invoke(HttpContext context)
        {
            // Burada artık bl yazılır

            if (context.Request.Path.Value.Contains("berkayakar"))
            {
                throw new ArgumentException("Berkay adlı bir adet endpint isteği geldi ");
            }


            // işlemler bittikten sonra bir sonraki middleware e gidilir. 
            await _requestDelegate.Invoke(context);  // Pipline sıralamasında ilgili işlemler yapıldıktan sonra bir sonraki middleware i tetikletebilmek için eklenmiş olan methoddur. 
        }
    }
}
