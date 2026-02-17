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
    public sealed class CustomerSegmentMembershipOperationQueryBuilder : FieldsQueryBuilderBase<SegmentMembershipResponse, CustomerSegmentMembershipOperationQueryBuilder>, IGraphOperationQueryBuilder<SegmentMembershipResponse>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CustomerSegmentMembershipArgumentsBuilder Arguments { get; }
        protected override CustomerSegmentMembershipOperationQueryBuilder Self => this;

        public CustomerSegmentMembershipOperationQueryBuilder() : this("customerSegmentMembership")
        {
        }

        public CustomerSegmentMembershipOperationQueryBuilder(string name) : base(new Query<SegmentMembershipResponse>(name))
        {
            Arguments = new CustomerSegmentMembershipArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSegmentMembershipOperationQueryBuilder(IQuery<SegmentMembershipResponse> query) : base(query)
        {
            Arguments = new CustomerSegmentMembershipArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSegmentMembershipOperationQueryBuilder Memberships(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentMembershipQueryBuilder> build)
        {
            var query = new Query<SegmentMembership>("memberships");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentMembershipQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentMembership>(query);
            return this;
        }
    }
}