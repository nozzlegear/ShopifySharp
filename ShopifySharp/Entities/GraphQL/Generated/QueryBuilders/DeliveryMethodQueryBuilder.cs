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

public class DeliveryMethodQueryBuilder() : GraphQueryBuilder<DeliveryMethod>("query deliveryMethod")
{
    public DeliveryMethodQueryBuilder AddFieldAdditionalInformation()
    {
        AddField("additionalInformation");
        return this;
    }

    public DeliveryMethodQueryBuilder AddFieldBrandedPromise()
    {
        AddField("brandedPromise");
        return this;
    }

    public DeliveryMethodQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryMethodQueryBuilder AddFieldMaxDeliveryDateTime()
    {
        AddField("maxDeliveryDateTime");
        return this;
    }

    public DeliveryMethodQueryBuilder AddFieldMethodType()
    {
        AddField("methodType");
        return this;
    }

    public DeliveryMethodQueryBuilder AddFieldMinDeliveryDateTime()
    {
        AddField("minDeliveryDateTime");
        return this;
    }

    public DeliveryMethodQueryBuilder AddFieldPresentedName()
    {
        AddField("presentedName");
        return this;
    }

    public DeliveryMethodQueryBuilder AddFieldServiceCode()
    {
        AddField("serviceCode");
        return this;
    }

    public DeliveryMethodQueryBuilder AddFieldSourceReference()
    {
        AddField("sourceReference");
        return this;
    }
}