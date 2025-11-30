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

public class DeliveryPromiseParticipantQueryBuilder() : GraphQueryBuilder<DeliveryPromiseParticipant>("deliveryPromiseParticipant")
{
    public DeliveryPromiseParticipantQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryPromiseParticipantQueryBuilder AddUnionCaseOwner(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddUnion<ProductVariant, ProductVariantQueryBuilder>("owner", build);
        return this;
    }

    public DeliveryPromiseParticipantQueryBuilder AddFieldOwnerType()
    {
        AddField("ownerType");
        return this;
    }
}