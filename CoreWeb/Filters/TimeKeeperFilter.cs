using CoreWeb.Code;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace CoreWeb.Filters
{
    public class TimeKeeperFilter : IActionFilter
    {
        private readonly IMyWriter _writer;
        private static string _TimeKeeperKey = "TimeKeeperKey";
        
        public TimeKeeperFilter(IMyWriter writer) 
        {
            _writer = writer;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            _writer.ToConsole(context.GetRouteStr()+" executing");
            context.HttpContext.Items.Add(_TimeKeeperKey, stopwatch);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Stopwatch stopwatch = (Stopwatch)context.HttpContext.Items[_TimeKeeperKey];
            stopwatch.Stop();
            _writer.ToConsole(context.GetRouteStr() + " executed in "+ stopwatch.ElapsedMilliseconds.ToString()+"ms");
            System.Console.WriteLine();
        }
    }
}
