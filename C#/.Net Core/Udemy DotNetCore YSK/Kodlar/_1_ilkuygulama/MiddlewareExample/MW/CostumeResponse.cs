using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MiddlewareExample.MW
{
    public class CostumeResponse
    {
        private RequestDelegate _request;

        public CostumeResponse(RequestDelegate request)
        {
            _request = request;
        }

        public async Task Invoke(HttpContext context)
        {
            await _request.Invoke(context); // request delegate i içerisinde yer alan invoke yardımı ile sonraki middleware e gönderilirir kod.

            if (context.Request.Path.ToString() == "/berkay")
                await context.Response.WriteAsync("Berkay a get geldi");
        }
    }
}
