using System.Net;
using CameYA.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CameYA.Infrastructure.Filters
{
    public class BusinessExceptionFilters : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if(context.Exception.GetType() == typeof(BusinessException))
            {
                var exception = (BusinessException)context.Exception;
                var excp_value = new
                {
                    Status = 400,
                    Title = "Bad Request",
                    Detail = exception.Message,
                };

                var json = new
                {
                    errors = new[] { excp_value }
                };

                context.Result = new BadRequestObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.ExceptionHandled = true;
            }
        }
    }
}
