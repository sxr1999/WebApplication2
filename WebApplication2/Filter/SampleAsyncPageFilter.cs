using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication2.Filter
{
    public class SampleAsyncPageFilter : IAsyncPageFilter
    {
        public async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context,
                                                  PageHandlerExecutionDelegate next)
        {
            // Do post work.
            await next.Invoke();
        }

        public Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            Console.WriteLine("Pagefilter start");

            return Task.CompletedTask;
        }


    }
}
