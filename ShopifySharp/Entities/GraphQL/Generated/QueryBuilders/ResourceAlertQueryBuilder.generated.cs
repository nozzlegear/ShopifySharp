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

public class ResourceAlertQueryBuilder() : GraphQueryBuilder<ResourceAlert>("resourceAlert")
{
    public ResourceAlertQueryBuilder AddFieldActions(Func<ResourceAlertActionQueryBuilder, ResourceAlertActionQueryBuilder> build)
    {
        AddField<ResourceAlertAction, ResourceAlertActionQueryBuilder>("actions", build);
        return this;
    }

    public ResourceAlertQueryBuilder AddFieldContent()
    {
        AddField("content");
        return this;
    }

    public ResourceAlertQueryBuilder AddFieldDismissibleHandle()
    {
        AddField("dismissibleHandle");
        return this;
    }

    public ResourceAlertQueryBuilder AddFieldIcon()
    {
        AddField("icon");
        return this;
    }

    public ResourceAlertQueryBuilder AddFieldSeverity()
    {
        AddField("severity");
        return this;
    }

    public ResourceAlertQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}