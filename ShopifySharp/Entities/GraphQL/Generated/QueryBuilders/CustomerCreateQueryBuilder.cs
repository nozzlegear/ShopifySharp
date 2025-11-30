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

public class CustomerCreateQueryBuilder() : GraphQueryBuilder<CustomerCreatePayload>("query customerCreate")
{
    public CustomerCreateQueryBuilder AddArgumentInput(CustomerInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}