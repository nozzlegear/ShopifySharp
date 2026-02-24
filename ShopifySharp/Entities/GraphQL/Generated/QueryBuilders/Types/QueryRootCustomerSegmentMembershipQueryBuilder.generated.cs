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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootCustomerSegmentMembershipQueryBuilder : FieldsQueryBuilderBase<SegmentMembershipResponse, QueryRootCustomerSegmentMembershipQueryBuilder>, IHasArguments<QueryRootCustomerSegmentMembershipArgumentsBuilder>
    {
        public QueryRootCustomerSegmentMembershipArgumentsBuilder Arguments { get; }
        protected override QueryRootCustomerSegmentMembershipQueryBuilder Self => this;

        public QueryRootCustomerSegmentMembershipQueryBuilder(string name) : base(new Query<SegmentMembershipResponse>(name))
        {
            Arguments = new QueryRootCustomerSegmentMembershipArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerSegmentMembershipQueryBuilder(IQuery<SegmentMembershipResponse> query) : base(query)
        {
            Arguments = new QueryRootCustomerSegmentMembershipArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerSegmentMembershipQueryBuilder SetArguments(Action<QueryRootCustomerSegmentMembershipArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCustomerSegmentMembershipQueryBuilder Memberships(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentMembershipQueryBuilder> build)
        {
            var query = new Query<SegmentMembership>("memberships");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentMembershipQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentMembership>(query);
            return this;
        }
    }
}