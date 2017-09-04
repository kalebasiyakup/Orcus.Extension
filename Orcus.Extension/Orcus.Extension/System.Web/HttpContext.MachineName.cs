using System;
using System.Security;
using System.Web;

public static partial class OrcusHttpContextExtension
{
    public static string MachineName(this HttpContext httpContext)
    {
        httpContext.ThrowIfNull(nameof(httpContext));

        try
        {
            var machineName = httpContext.Server.MachineName;
            return machineName;
        }
        catch (HttpException)
        {
        }
        catch (SecurityException)
        {
        }

        try
        {
            var machineName = Environment.MachineName;
            return machineName;
        }
        catch (SecurityException)
        {
        }

        return string.Empty;
    }
}
