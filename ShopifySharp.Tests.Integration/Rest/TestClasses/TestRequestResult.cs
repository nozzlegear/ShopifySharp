#nullable enable

using System.Net;
using System.Net.Http;

namespace ShopifySharp.Tests.Integration.Rest.TestClasses;

public class TestRequestResult<T>(T result) : RequestResult<T>("",
    new HttpResponseMessage(HttpStatusCode.OK).Headers,
    result,
    "",
    "",
    HttpStatusCode.OK);
