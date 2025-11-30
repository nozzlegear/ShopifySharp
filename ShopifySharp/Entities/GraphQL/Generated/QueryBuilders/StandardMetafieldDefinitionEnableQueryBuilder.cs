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

public class StandardMetafieldDefinitionEnableQueryBuilder() : GraphQueryBuilder<StandardMetafieldDefinitionEnablePayload>("query standardMetafieldDefinitionEnable")
{
    public StandardMetafieldDefinitionEnableQueryBuilder AddArgumentAccess(StandardMetafieldDefinitionAccessInput? access)
    {
        AddArgument("access", access);
        return this;
    }

    public StandardMetafieldDefinitionEnableQueryBuilder AddArgumentCapabilities(MetafieldCapabilityCreateInput? capabilities)
    {
        AddArgument("capabilities", capabilities);
        return this;
    }

    public StandardMetafieldDefinitionEnableQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public StandardMetafieldDefinitionEnableQueryBuilder AddArgumentKey(string? key)
    {
        AddArgument("key", key);
        return this;
    }

    public StandardMetafieldDefinitionEnableQueryBuilder AddArgumentNamespace(string? @namespace)
    {
        AddArgument("namespace", @namespace);
        return this;
    }

    public StandardMetafieldDefinitionEnableQueryBuilder AddArgumentOwnerType(MetafieldOwnerType? ownerType)
    {
        AddArgument("ownerType", ownerType);
        return this;
    }

    public StandardMetafieldDefinitionEnableQueryBuilder AddArgumentPin(bool? pin)
    {
        AddArgument("pin", pin);
        return this;
    }
}