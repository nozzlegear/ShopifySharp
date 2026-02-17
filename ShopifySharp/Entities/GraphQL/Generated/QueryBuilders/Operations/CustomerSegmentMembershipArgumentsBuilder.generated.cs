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
    public sealed class CustomerSegmentMembershipArgumentsBuilder : ArgumentsBuilderBase<SegmentMembershipResponse, CustomerSegmentMembershipArgumentsBuilder>
    {
        protected override CustomerSegmentMembershipArgumentsBuilder Self => this;

        public CustomerSegmentMembershipArgumentsBuilder(IQuery<SegmentMembershipResponse> query) : base(query)
        {
        }

        public CustomerSegmentMembershipArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }

        public CustomerSegmentMembershipArgumentsBuilder SegmentIds(ICollection<string>? segmentIds)
        {
            base.InnerQuery.AddArgument("segmentIds", segmentIds);
            return this;
        }
    }
}