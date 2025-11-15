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

public class ShopifyPaymentsMerchantCategoryCodeQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsMerchantCategoryCode>("query shopifyPaymentsMerchantCategoryCode")
{
    public ShopifyPaymentsMerchantCategoryCodeQueryBuilder AddFieldCategory()
    {
        AddField("category");
        return this;
    }

    public ShopifyPaymentsMerchantCategoryCodeQueryBuilder AddFieldCategoryLabel()
    {
        AddField("categoryLabel");
        return this;
    }

    public ShopifyPaymentsMerchantCategoryCodeQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ShopifyPaymentsMerchantCategoryCodeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopifyPaymentsMerchantCategoryCodeQueryBuilder AddFieldSubcategoryLabel()
    {
        AddField("subcategoryLabel");
        return this;
    }
}