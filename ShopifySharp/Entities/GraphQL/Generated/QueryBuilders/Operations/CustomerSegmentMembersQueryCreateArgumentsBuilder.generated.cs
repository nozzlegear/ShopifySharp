#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
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