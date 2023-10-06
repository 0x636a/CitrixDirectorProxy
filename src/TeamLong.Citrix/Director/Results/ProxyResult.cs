using System.Net.Http;
using System.Text.Json.Serialization;

namespace TeamLong.Citrix.Director.Results;

public class ProxyResult
{
    [JsonIgnore] public HttpResponseMessage Response { get; set; }
}

public class ProxyResult<T> : ProxyResult
{
    public T Data { get; set; }

    public static ProxyResult<T> Create(HttpResponseMessage res, T data)
    {
        var result = new ProxyResult<T>
        {
            Response = res,
            Data = data
        };

        return result;
    }
}