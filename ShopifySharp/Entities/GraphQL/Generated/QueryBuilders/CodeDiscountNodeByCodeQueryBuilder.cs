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

public class CodeDiscountNodeByCodeQueryBuilder() : GraphQueryBuilder<DiscountCodeNode>("query codeDiscountNodeByCode")
{
    public CodeDiscountNodeByCodeQueryBuilder AddArgumentCode(string? code)
    {
        AddArgument("code", code);
        return this;
    }
}