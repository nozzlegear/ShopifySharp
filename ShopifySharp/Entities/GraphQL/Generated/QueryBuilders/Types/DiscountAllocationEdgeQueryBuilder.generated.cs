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
    public sealed class DiscountAllocationEdgeQueryBuilder : FieldsQueryBuilderBase<DiscountAllocationEdge, DiscountAllocationEdgeQueryBuilder>
    {
        protected override DiscountAllocationEdgeQueryBuilder Self => this;

        public DiscountAllocationEdgeQueryBuilder() : this("discountAllocationEdge")
        {
        }

        public DiscountAllocationEdgeQueryBuilder(string name) : base(new Query<DiscountAllocationEdge>(name))
        {
        }

        public DiscountAllocationEdgeQueryBuilder(IQuery<DiscountAllocationEdge> query) : base(query)
        {
        }

        public DiscountAllocationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DiscountAllocationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationQueryBuilder> build)
        {
            var query = new Query<DiscountAllocation>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAllocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAllocation>(query);
            return this;
        }
    }
}