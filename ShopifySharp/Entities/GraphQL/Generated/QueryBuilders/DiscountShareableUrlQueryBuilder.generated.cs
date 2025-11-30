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

public class DiscountShareableUrlQueryBuilder() : GraphQueryBuilder<DiscountShareableUrl>("discountShareableUrl")
{
    public DiscountShareableUrlQueryBuilder AddFieldTargetItemImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("targetItemImage", build);
        return this;
    }

    public DiscountShareableUrlQueryBuilder AddFieldTargetType()
    {
        AddField("targetType");
        return this;
    }

    public DiscountShareableUrlQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public DiscountShareableUrlQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}