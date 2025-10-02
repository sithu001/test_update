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

            var host = context.Request.Host.Host;
            var path = context.Request.Path.Value?.ToLower() ?? "";

            // Allow login/logout/accessdenied without redirect loops
            if (path.StartsWith("/account/login") ||
                path.StartsWith("/account/accessdenied") ||
                path.StartsWith("/account/logout"))
            {
                await _next(context);
                return;
            }

            // If request is to the admin subdomain
            if (host.StartsWith("admin.", StringComparison.OrdinalIgnoreCase))
            {
                // If not logged in → go to login
                if (!context.User.Identity?.IsAuthenticated ?? true)
                {
                    context.Response.Redirect("/Account/Login");
                    return;
                }

                // If logged in but not admin → access denied
                if (!context.User.IsInRole("Admin"))
                {
                    context.Response.Redirect("/Account/AccessDenied");
                    return;
                }

                // If admin subdomain root → redirect to Admin dashboard
                if (string.IsNullOrEmpty(path) || path == "/")
                {
                    context.Response.Redirect("/Admin/Index");
                    return;
                }
            }

            await _next(context);
        }
    }
}
