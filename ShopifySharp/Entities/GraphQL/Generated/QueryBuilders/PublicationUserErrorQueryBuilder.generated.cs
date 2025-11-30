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

public class PublicationUserErrorQueryBuilder() : GraphQueryBuilder<PublicationUserError>("publicationUserError")
{
    public PublicationUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public PublicationUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public PublicationUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}