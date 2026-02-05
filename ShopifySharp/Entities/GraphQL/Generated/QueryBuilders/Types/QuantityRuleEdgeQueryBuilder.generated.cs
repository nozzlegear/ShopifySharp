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

        public QuantityRuleEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleQueryBuilder> build)
        {
            var query = new Query<QuantityRule>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRule>(query);
            return this;
        }
    }
}