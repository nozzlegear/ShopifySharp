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

public class DeliveryAvailableServiceQueryBuilder() : GraphQueryBuilder<DeliveryAvailableService>("deliveryAvailableService")
{
    public DeliveryAvailableServiceQueryBuilder AddFieldCountries(Func<DeliveryCountryCodesOrRestOfWorldQueryBuilder, DeliveryCountryCodesOrRestOfWorldQueryBuilder> build)
    {
        AddField<DeliveryCountryCodesOrRestOfWorld, DeliveryCountryCodesOrRestOfWorldQueryBuilder>("countries", build);
        return this;
    }

    public DeliveryAvailableServiceQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}