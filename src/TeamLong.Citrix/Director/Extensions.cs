using System.Net.Http;
using TeamLong.Citrix.Director.Results;

namespace TeamLong.Citrix.Director;

public static class Extensions
{
    public static ProxyResult<T> ProxyResult<T>(this HttpResponseMessage response, T data)
    {
        var result = new ProxyResult<T> { Response = response, Data = data };
        return result;
    }

    public static ProxyResult ProxyResult(this HttpResponseMessage response)
    {
        var result = new ProxyResult { Response = response };
        return result;
    }
}