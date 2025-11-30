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

public class CustomerSegmentMembersQueryCreatePayloadQueryBuilder() : GraphQueryBuilder<CustomerSegmentMembersQueryCreatePayload>("customerSegmentMembersQueryCreatePayload")
{
    public CustomerSegmentMembersQueryCreatePayloadQueryBuilder AddFieldCustomerSegmentMembersQuery(Func<CustomerSegmentMembersQueryQueryBuilder, CustomerSegmentMembersQueryQueryBuilder> build)
    {
        AddField<CustomerSegmentMembersQuery, CustomerSegmentMembersQueryQueryBuilder>("customerSegmentMembersQuery", build);
        return this;
    }

    public CustomerSegmentMembersQueryCreatePayloadQueryBuilder AddFieldUserErrors(Func<CustomerSegmentMembersQueryUserErrorQueryBuilder, CustomerSegmentMembersQueryUserErrorQueryBuilder> build)
    {
        AddField<CustomerSegmentMembersQueryUserError, CustomerSegmentMembersQueryUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}