#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CustomerSegmentMembersQueryCreateArgumentsBuilder : ArgumentsBuilderBase<CustomerSegmentMembersQueryCreatePayload, CustomerSegmentMembersQueryCreateArgumentsBuilder>
    {
        protected override CustomerSegmentMembersQueryCreateArgumentsBuilder Self => this;

        public CustomerSegmentMembersQueryCreateArgumentsBuilder(IQuery<CustomerSegmentMembersQueryCreatePayload> query) : base(query)
        {
        }

        public CustomerSegmentMembersQueryCreateArgumentsBuilder Input(CustomerSegmentMembersQueryInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}