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

public class AddAllProductsOperationQueryBuilder() : GraphQueryBuilder<AddAllProductsOperation>("query addAllProductsOperation")
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

    public AddAllProductsOperationQueryBuilder AddFieldRowCount()
    {
        AddField("rowCount");
        return this;
    }

    public AddAllProductsOperationQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}