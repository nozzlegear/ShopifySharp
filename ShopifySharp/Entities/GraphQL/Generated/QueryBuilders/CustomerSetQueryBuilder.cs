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

public class CustomerSetQueryBuilder() : GraphQueryBuilder<CustomerSetPayload>("query customerSet")
{
    public CustomerSetQueryBuilder AddArgumentIdentifier(CustomerSetIdentifiers? identifier)
    {
        AddArgument("identifier", identifier);
        return this;
    }

    public CustomerSetQueryBuilder AddArgumentInput(CustomerSetInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}