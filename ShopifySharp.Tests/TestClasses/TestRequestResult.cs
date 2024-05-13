#nullable enable

using System.Net;
using System.Net.Http;

namespace ShopifySharp.Tests.TestClasses;

public class TestRequestResult<T> : RequestResult<T>
{
    public TestRequestResult(
        T result
    ) : base("",
        new HttpResponseMessage(HttpStatusCode.OK),
        new HttpResponseMessage(HttpStatusCode.OK).Headers,
        result,
        "",
        "",
        HttpStatusCode.OK
    )
    {
    }
}
