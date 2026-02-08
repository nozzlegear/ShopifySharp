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
    public sealed class SellingPlanConnectionQueryBuilder : FieldsQueryBuilderBase<SellingPlanConnection, SellingPlanConnectionQueryBuilder>
    {
        protected override SellingPlanConnectionQueryBuilder Self => this;

        public SellingPlanConnectionQueryBuilder() : this("sellingPlanConnection")
        {
        }

        public SellingPlanConnectionQueryBuilder(string name) : base(new Query<SellingPlanConnection>(name))
        {
        }

        public SellingPlanConnectionQueryBuilder(IQuery<SellingPlanConnection> query) : base(query)
        {
        }

        public SellingPlanConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanEdgeQueryBuilder> build)
        {
            var query = new Query<SellingPlanEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanEdge>(query);
            return this;
        }

        public SellingPlanConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanQueryBuilder> build)
        {
            var query = new Query<SellingPlan>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlan>(query);
            return this;
        }

        public SellingPlanConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}