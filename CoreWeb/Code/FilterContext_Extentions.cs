using Microsoft.AspNetCore.Mvc.Filters;

namespace CoreWeb.Code
{
    public static class FilterContext_Extentions
    {
        public static string GetControllerName(this FilterContext context)
        {
            return context.RouteData.Values["controller"].ToString();
        }

        public static string GetActionName(this FilterContext context)
        {
            return context.RouteData.Values["action"].ToString();
        }
      
        public static string GetRouteStr(this FilterContext context)
        {
            return context.GetControllerName() + ":" + context.GetActionName();
        }
    }
}
