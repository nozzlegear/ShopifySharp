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
    public sealed class DiscountAllocationConnectionQueryBuilder : FieldsQueryBuilderBase<DiscountAllocationConnection, DiscountAllocationConnectionQueryBuilder>
    {
        protected override DiscountAllocationConnectionQueryBuilder Self => this;

        public DiscountAllocationConnectionQueryBuilder() : this("discountAllocationConnection")
        {
        }

        public DiscountAllocationConnectionQueryBuilder(string name) : base(new Query<DiscountAllocationConnection>(name))
        {
        }

        public DiscountAllocationConnectionQueryBuilder(IQuery<DiscountAllocationConnection> query) : base(query)
        {
        }

        public DiscountAllocationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountAllocationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAllocationEdge>(query);
            return this;
        }

        public DiscountAllocationConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationQueryBuilder> build)
        {
            var query = new Query<DiscountAllocation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAllocation>(query);
            return this;
        }

        public DiscountAllocationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}