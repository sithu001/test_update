namespace MOCDEMSNEW.Middleware
{
    public class SubdomainAuthMiddleware
    {
        private readonly RequestDelegate _next;

        public SubdomainAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {          
            var host = context.Request.Host.Host.ToLower();
            var path = context.Request.Path.Value?.ToLower() ?? "";

           
            if (path.StartsWith("/account"))
            {
                await _next(context);
                return;
            }

            if (host.StartsWith("admin."))
            {
                if (!context.User.Identity?.IsAuthenticated ?? true)
                {
                    context.Response.Redirect("/Account/Login");
                    return;
                }

                if (!context.User.IsInRole("Admin"))
                {
                    context.Response.Redirect("/Account/AccessDenied");
                    return;
                }
            }            

            await _next(context);
          
        }

    }
}

    

