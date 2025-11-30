#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class FulfillmentOrderDestinationQueryBuilder() : GraphQueryBuilder<FulfillmentOrderDestination>("fulfillmentOrderDestination")
{
    public FulfillmentOrderDestinationQueryBuilder AddFieldAddress1()
    {
        AddField("address1");
        return this;
    }

    public FulfillmentOrderDestinationQueryBuilder AddFieldAddress2()
    {
        AddField("address2");
        return this;
    }

    public FulfillmentOrderDestinationQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public FulfillmentOrderDestinationQueryBuilder AddFieldCompany()
    {
        AddField("company");
        return this;
    }

    public FulfillmentOrderDestinationQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public FulfillmentOrderDestinationQueryBuilder AddFieldEmail()
    {
        AddField("email");
        return this;
    }

    public FulfillmentOrderDestinationQueryBuilder AddFieldFirstName()
    {
        AddField("firstName");
        return this;
    }

    public FulfillmentOrderDestinationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FulfillmentOrderDestinationQueryBuilder AddFieldLastName()
    {
        AddField("lastName");
        return this;
    }

    public FulfillmentOrderDestinationQueryBuilder AddFieldLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("location", build);
        return this;
    }

    public FulfillmentOrderDestinationQueryBuilder AddFieldPhone()
    {
        AddField("phone");
        return this;
    }

    public FulfillmentOrderDestinationQueryBuilder AddFieldProvince()
    {
        AddField("province");
        return this;
    }

    public FulfillmentOrderDestinationQueryBuilder AddFieldZip()
    {
        AddField("zip");
        return this;
    }
}