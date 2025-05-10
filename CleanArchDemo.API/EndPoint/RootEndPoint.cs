using System.Runtime.CompilerServices;

namespace CleanArchDemo.API.EndPoint
{
    public static class RootEndPoint
    {
        public static IEndpointRouteBuilder MapRoot(this IEndpointRouteBuilder routes)
        {
            routes.MapControllerRoute(
       name: "default",
       pattern: "{controller=User}/{action=Index}/{id?}");
            routes.MapGet("/", () => "Hello World!");
            return routes;
        }
    }
}
