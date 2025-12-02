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

public class DeliveryCarrierServiceQueryBuilder() : GraphQueryBuilder<DeliveryCarrierService>("deliveryCarrierService")
{
    public DeliveryCarrierServiceQueryBuilder AddFieldActive()
    {
        AddField("active");
        return this;
    }

    public DeliveryCarrierServiceQueryBuilder AddFieldAvailableServicesForCountries(Func<DeliveryAvailableServiceQueryBuilder, DeliveryAvailableServiceQueryBuilder> build)
    {
        AddField<DeliveryAvailableService, DeliveryAvailableServiceQueryBuilder>("availableServicesForCountries", build);
        return this;
    }

    public DeliveryCarrierServiceQueryBuilder AddFieldCallbackUrl()
    {
        AddField("callbackUrl");
        return this;
    }

    public DeliveryCarrierServiceQueryBuilder AddFieldFormattedName()
    {
        AddField("formattedName");
        return this;
    }

    public DeliveryCarrierServiceQueryBuilder AddFieldIcon(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("icon", build);
        return this;
    }

    public DeliveryCarrierServiceQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryCarrierServiceQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public DeliveryCarrierServiceQueryBuilder AddFieldSupportsServiceDiscovery()
    {
        AddField("supportsServiceDiscovery");
        return this;
    }
}