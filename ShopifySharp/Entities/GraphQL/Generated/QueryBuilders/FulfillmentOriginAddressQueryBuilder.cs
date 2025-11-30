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

public class FulfillmentOriginAddressQueryBuilder() : GraphQueryBuilder<FulfillmentOriginAddress>("query fulfillmentOriginAddress")
{
    public FulfillmentOriginAddressQueryBuilder AddFieldAddress1()
    {
        AddField("address1");
        return this;
    }

    public FulfillmentOriginAddressQueryBuilder AddFieldAddress2()
    {
        AddField("address2");
        return this;
    }

    public FulfillmentOriginAddressQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public FulfillmentOriginAddressQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public FulfillmentOriginAddressQueryBuilder AddFieldProvinceCode()
    {
        AddField("provinceCode");
        return this;
    }

    public FulfillmentOriginAddressQueryBuilder AddFieldZip()
    {
        AddField("zip");
        return this;
    }
}