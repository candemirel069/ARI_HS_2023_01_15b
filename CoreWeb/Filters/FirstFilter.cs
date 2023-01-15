using CoreWeb.Code;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace CoreWeb.Filters
{
    public class FirstFilter : IActionFilter
    {
        private readonly IMyWriter _writer;

        public FirstFilter(IMyWriter writer)
        {
            _writer = writer;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _writer.ToConsole("Executing");
            
        }  
        
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _writer.ToConsole("Executed");
            Console.WriteLine();
        }
    }
}
