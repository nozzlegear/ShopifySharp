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
    public sealed class QuantityRuleEdgeQueryBuilder : FieldsQueryBuilderBase<QuantityRuleEdge, QuantityRuleEdgeQueryBuilder>
    {
        protected override QuantityRuleEdgeQueryBuilder Self => this;

        public QuantityRuleEdgeQueryBuilder() : this("quantityRuleEdge")
        {
        }

        public QuantityRuleEdgeQueryBuilder(string name) : base(new Query<QuantityRuleEdge>(name))
        {
        }

        public QuantityRuleEdgeQueryBuilder(IQuery<QuantityRuleEdge> query) : base(query)
        {
        }

        public QuantityRuleEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public QuantityRuleEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleQueryBuilder> build)
        {
            var query = new Query<QuantityRule>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRule>(query);
            return this;
        }
    }
}