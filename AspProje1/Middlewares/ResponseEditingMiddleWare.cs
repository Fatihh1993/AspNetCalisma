using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProje1.Middlewares
{
    public class ResponseEditingMiddleWare
    {
        private RequestDelegate _requestDelegate;

        public ResponseEditingMiddleWare(RequestDelegate requestDelegate)

        {
            _requestDelegate = requestDelegate;

        }

        public async Task Invoke(HttpContext context)

        {

         await   _requestDelegate.Invoke(context);
            if (context.Response.StatusCode == StatusCodes.Status404NotFound)
                await context.Response.WriteAsync("Sayfa Bulunamadi");

        }
        
    }

}
