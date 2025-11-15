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

public class CustomerSegmentMembersQueryUserErrorQueryBuilder() : GraphQueryBuilder<CustomerSegmentMembersQueryUserError>("query customerSegmentMembersQueryUserError")
{
    public CustomerSegmentMembersQueryUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CustomerSegmentMembersQueryUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CustomerSegmentMembersQueryUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}