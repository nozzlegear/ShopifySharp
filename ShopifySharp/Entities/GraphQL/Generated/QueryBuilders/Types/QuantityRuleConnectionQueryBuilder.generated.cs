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
    public sealed class QuantityRuleConnectionQueryBuilder : FieldsQueryBuilderBase<QuantityRuleConnection, QuantityRuleConnectionQueryBuilder>
    {
        protected override QuantityRuleConnectionQueryBuilder Self => this;

        public QuantityRuleConnectionQueryBuilder() : this("quantityRuleConnection")
        {
        }

        public QuantityRuleConnectionQueryBuilder(string name) : base(new Query<QuantityRuleConnection>(name))
        {
        }

        public QuantityRuleConnectionQueryBuilder(IQuery<QuantityRuleConnection> query) : base(query)
        {
        }

        public QuantityRuleConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleEdgeQueryBuilder> build)
        {
            var query = new Query<QuantityRuleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRuleEdge>(query);
            return this;
        }

        public QuantityRuleConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleQueryBuilder> build)
        {
            var query = new Query<QuantityRule>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRule>(query);
            return this;
        }

        public QuantityRuleConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}