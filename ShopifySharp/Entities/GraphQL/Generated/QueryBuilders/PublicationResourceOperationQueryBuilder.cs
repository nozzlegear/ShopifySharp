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

public class PublicationResourceOperationQueryBuilder() : GraphQueryBuilder<PublicationResourceOperation>("query publicationResourceOperation")
{
    public PublicationResourceOperationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public PublicationResourceOperationQueryBuilder AddFieldProcessedRowCount()
    {
        AddField("processedRowCount");
        return this;
    }

    public PublicationResourceOperationQueryBuilder AddFieldRowCount()
    {
        AddField("rowCount");
        return this;
    }

    public PublicationResourceOperationQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}