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

public class DeliveryProfilesQueryBuilder() : GraphQueryBuilder<DeliveryProfileConnection>("query deliveryProfiles")
{
    public DeliveryProfilesQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public DeliveryProfilesQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public DeliveryProfilesQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public DeliveryProfilesQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public DeliveryProfilesQueryBuilder AddArgumentMerchantOwnedOnly(bool? merchantOwnedOnly)
    {
        AddArgument("merchantOwnedOnly", merchantOwnedOnly);
        return this;
    }

    public DeliveryProfilesQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }
}