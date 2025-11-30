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

public class ScriptTagUpdatePayloadQueryBuilder() : GraphQueryBuilder<ScriptTagUpdatePayload>("scriptTagUpdatePayload")
{
    public ScriptTagUpdatePayloadQueryBuilder AddFieldScriptTag(Func<ScriptTagQueryBuilder, ScriptTagQueryBuilder> build)
    {
        AddField<ScriptTag, ScriptTagQueryBuilder>("scriptTag", build);
        return this;
    }

    public ScriptTagUpdatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}