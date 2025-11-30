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

public class AddAllProductsOperationQueryBuilder() : GraphQueryBuilder<AddAllProductsOperation>("addAllProductsOperation")
{
    public AddAllProductsOperationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AddAllProductsOperationQueryBuilder AddFieldProcessedRowCount()
    {
        AddField("processedRowCount");
        return this;
    }

    public AddAllProductsOperationQueryBuilder AddFieldRowCount(Func<RowCountQueryBuilder, RowCountQueryBuilder> build)
    {
        AddField<RowCount, RowCountQueryBuilder>("rowCount", build);
        return this;
    }

    public AddAllProductsOperationQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}