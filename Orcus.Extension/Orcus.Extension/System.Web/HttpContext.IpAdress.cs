using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Web;

public static partial class OrcusHttpContextExtension
{
    public static string IpAdress(this HttpContext httpContext)
    {
        httpContext.ExceptionIfNull(nameof(httpContext));

        try
        {
            var sourceIp = string.IsNullOrEmpty(HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"])
                ? HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"]
                : HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            return sourceIp;
        }
        catch (HttpException)
        {
        }
        catch (SecurityException)
        {
        }

        try
        {
            var localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress addr in localIPs.Where(addr => addr.AddressFamily == AddressFamily.InterNetwork))
            {
                return addr.ToString();
            }
        }
        catch (SecurityException)
        {
        }

        return string.Empty;
    }
}
