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

public class CustomerSegmentMembersQueryCreatePayloadQueryBuilder() : GraphQueryBuilder<CustomerSegmentMembersQueryCreatePayload>("query customerSegmentMembersQueryCreatePayload")
{
    public CustomerSegmentMembersQueryCreatePayloadQueryBuilder AddFieldCustomerSegmentMembersQuery()
    {
        AddField("customerSegmentMembersQuery");
        return this;
    }

    public CustomerSegmentMembersQueryCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}