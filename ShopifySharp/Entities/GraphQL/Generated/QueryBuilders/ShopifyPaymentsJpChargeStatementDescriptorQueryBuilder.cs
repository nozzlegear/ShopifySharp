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

public class ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsJpChargeStatementDescriptor>("query shopifyPaymentsJpChargeStatementDescriptor")
{
    public ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder AddFieldDefault()
    {
        AddField("default");
        return this;
    }

    public ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder AddFieldKana()
    {
        AddField("kana");
        return this;
    }

    public ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder AddFieldKanji()
    {
        AddField("kanji");
        return this;
    }

    public ShopifyPaymentsJpChargeStatementDescriptorQueryBuilder AddFieldPrefix()
    {
        AddField("prefix");
        return this;
    }
}