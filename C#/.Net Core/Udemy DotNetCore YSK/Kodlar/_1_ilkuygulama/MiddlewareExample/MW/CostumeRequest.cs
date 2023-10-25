using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace MiddlewareExample.MW
{
    public class CostumeRequest
    {
        private RequestDelegate _request;

        public CostumeRequest(RequestDelegate request)
        {
            _request = request;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.ToString() == "/berkay")
                await context.Response.WriteAsync("Berkay a get geldi");
            else
                await _request.Invoke(context); // request delegate i içerisinde yer alan invoke yardımı ile sonraki middleware e gönderilirir kod.
        }
    }
}
