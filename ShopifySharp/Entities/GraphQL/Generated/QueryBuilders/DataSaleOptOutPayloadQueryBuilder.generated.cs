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

public class DataSaleOptOutPayloadQueryBuilder() : GraphQueryBuilder<DataSaleOptOutPayload>("dataSaleOptOutPayload")
{
    public DataSaleOptOutPayloadQueryBuilder AddFieldCustomerId()
    {
        AddField("customerId");
        return this;
    }

    public DataSaleOptOutPayloadQueryBuilder AddFieldUserErrors(Func<DataSaleOptOutUserErrorQueryBuilder, DataSaleOptOutUserErrorQueryBuilder> build)
    {
        AddField<DataSaleOptOutUserError, DataSaleOptOutUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}