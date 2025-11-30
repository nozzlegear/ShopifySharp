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

public class TranslationUserErrorQueryBuilder() : GraphQueryBuilder<TranslationUserError>("query translationUserError")
{
    public TranslationUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public TranslationUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public TranslationUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}