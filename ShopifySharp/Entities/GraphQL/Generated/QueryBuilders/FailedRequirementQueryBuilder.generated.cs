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

public class FailedRequirementQueryBuilder() : GraphQueryBuilder<FailedRequirement>("failedRequirement")
{
    public FailedRequirementQueryBuilder AddFieldAction(Func<NavigationItemQueryBuilder, NavigationItemQueryBuilder> build)
    {
        AddField<NavigationItem, NavigationItemQueryBuilder>("action", build);
        return this;
    }

    public FailedRequirementQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}