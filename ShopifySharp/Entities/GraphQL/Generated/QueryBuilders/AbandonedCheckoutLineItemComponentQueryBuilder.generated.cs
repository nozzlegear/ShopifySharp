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

public class AbandonedCheckoutLineItemComponentQueryBuilder() : GraphQueryBuilder<AbandonedCheckoutLineItemComponent>("abandonedCheckoutLineItemComponent")
{
    public AbandonedCheckoutLineItemComponentQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AbandonedCheckoutLineItemComponentQueryBuilder AddFieldImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("image", build);
        return this;
    }

    public AbandonedCheckoutLineItemComponentQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public AbandonedCheckoutLineItemComponentQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public AbandonedCheckoutLineItemComponentQueryBuilder AddFieldVariantTitle()
    {
        AddField("variantTitle");
        return this;
    }
}