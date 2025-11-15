#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ReturnProcessQueryBuilder() : GraphQueryBuilder<ReturnProcessPayload>("query returnProcess")
{
    public ReturnProcessQueryBuilder AddArgumentInput(ReturnProcessInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}