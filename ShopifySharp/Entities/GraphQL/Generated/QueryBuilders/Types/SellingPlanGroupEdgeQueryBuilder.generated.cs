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
    public sealed class SellingPlanGroupEdgeQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupEdge, SellingPlanGroupEdgeQueryBuilder>
    {
        protected override SellingPlanGroupEdgeQueryBuilder Self => this;

        public SellingPlanGroupEdgeQueryBuilder() : this("sellingPlanGroupEdge")
        {
        }

        public SellingPlanGroupEdgeQueryBuilder(string name) : base(new Query<SellingPlanGroupEdge>(name))
        {
        }

        public SellingPlanGroupEdgeQueryBuilder(IQuery<SellingPlanGroupEdge> query) : base(query)
        {
        }

        public SellingPlanGroupEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SellingPlanGroupEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }
    }
}