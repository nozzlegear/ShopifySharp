#nullable enable

using System;
using System.Net.Http;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Tests.Integration.Rest.TestClasses;

public class TestCloneableRequestMessage : CloneableRequestMessage, IDisposable
{
    public TestCloneableRequestMessage()
        : base(
            new Uri("https://github.com/nozzlegear/shopifysharp"),
            HttpMethod.Get,
            null
        )
    {
    }

    public new virtual void Dispose()
    {
        base.Dispose();
    }
}

