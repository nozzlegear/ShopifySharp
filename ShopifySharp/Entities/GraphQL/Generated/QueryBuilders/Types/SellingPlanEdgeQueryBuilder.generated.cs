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
    public sealed class SellingPlanEdgeQueryBuilder : FieldsQueryBuilderBase<SellingPlanEdge, SellingPlanEdgeQueryBuilder>
    {
        protected override SellingPlanEdgeQueryBuilder Self => this;

        public SellingPlanEdgeQueryBuilder() : this("sellingPlanEdge")
        {
        }

        public SellingPlanEdgeQueryBuilder(string name) : base(new Query<SellingPlanEdge>(name))
        {
        }

        public SellingPlanEdgeQueryBuilder(IQuery<SellingPlanEdge> query) : base(query)
        {
        }

        public SellingPlanEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SellingPlanEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanQueryBuilder> build)
        {
            var query = new Query<SellingPlan>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlan>(query);
            return this;
        }
    }
}