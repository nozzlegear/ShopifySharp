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

public class CustomerStatisticsQueryBuilder() : GraphQueryBuilder<CustomerStatistics>("query customerStatistics")
{
    public CustomerStatisticsQueryBuilder AddFieldPredictedSpendTier()
    {
        AddField("predictedSpendTier");
        return this;
    }

    public CustomerStatisticsQueryBuilder AddFieldRfmGroup()
    {
        AddField("rfmGroup");
        return this;
    }
}