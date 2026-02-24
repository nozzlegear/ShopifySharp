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
    public sealed class QueryRootCustomerSegmentMembersQueryBuilder : FieldsQueryBuilderBase<CustomerSegmentMemberConnection, QueryRootCustomerSegmentMembersQueryBuilder>, IHasArguments<QueryRootCustomerSegmentMembersArgumentsBuilder>
    {
        public QueryRootCustomerSegmentMembersArgumentsBuilder Arguments { get; }
        protected override QueryRootCustomerSegmentMembersQueryBuilder Self => this;

        public QueryRootCustomerSegmentMembersQueryBuilder(string name) : base(new Query<CustomerSegmentMemberConnection>(name))
        {
            Arguments = new QueryRootCustomerSegmentMembersArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerSegmentMembersQueryBuilder(IQuery<CustomerSegmentMemberConnection> query) : base(query)
        {
            Arguments = new QueryRootCustomerSegmentMembersArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerSegmentMembersQueryBuilder SetArguments(Action<QueryRootCustomerSegmentMembersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCustomerSegmentMembersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSegmentMemberEdgeQueryBuilder> build)
        {
            var query = new Query<CustomerSegmentMemberEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSegmentMemberEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSegmentMemberEdge>(query);
            return this;
        }

        public QueryRootCustomerSegmentMembersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public QueryRootCustomerSegmentMembersQueryBuilder Statistics(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentStatisticsQueryBuilder> build)
        {
            var query = new Query<SegmentStatistics>("statistics");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentStatisticsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentStatistics>(query);
            return this;
        }

        public QueryRootCustomerSegmentMembersQueryBuilder TotalCount()
        {
            base.InnerQuery.AddField("totalCount");
            return this;
        }
    }
}