using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.Hosting;

namespace WebAPI.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app, IWebHostEnvironment env){

    if (env.IsDevelopment())
    {
    app.UseSwagger();
    app.UseSwaggerUI();

    }
    //MÁSHOGY NÉZ KI A PROGRM CS BEN
    else{
    app.UseExceptionHandler(
        options=>{
            options.Run(
                async context =>{
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    var ex = context.Features.Get<IExceptionHandlerFeature>();
                    if (ex != null){
                        await context.Response.WriteAsync(ex.Error.Message);
                      }
                 }
                );
         }
        );
    }

        }
        
    }
}