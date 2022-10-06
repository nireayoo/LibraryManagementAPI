namespace LibraryManagementAPI
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new NotImplementedException();
            await context.Response.WriteAsync("Hello from file 1");

        }
    }
}
