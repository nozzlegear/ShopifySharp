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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
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

        public SellingPlanEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanQueryBuilder> build)
        {
            var query = new Query<SellingPlan>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlan>(query);
            return this;
        }
    }
}