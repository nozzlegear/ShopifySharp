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
    public sealed class PriceRuleDiscountCodeEdgeQueryBuilder : FieldsQueryBuilderBase<PriceRuleDiscountCodeEdge, PriceRuleDiscountCodeEdgeQueryBuilder>
    {
        protected override PriceRuleDiscountCodeEdgeQueryBuilder Self => this;

        public PriceRuleDiscountCodeEdgeQueryBuilder() : this("priceRuleDiscountCodeEdge")
        {
        }

        public PriceRuleDiscountCodeEdgeQueryBuilder(string name) : base(new Query<PriceRuleDiscountCodeEdge>(name))
        {
        }

        public PriceRuleDiscountCodeEdgeQueryBuilder(IQuery<PriceRuleDiscountCodeEdge> query) : base(query)
        {
        }

        public PriceRuleDiscountCodeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public PriceRuleDiscountCodeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleDiscountCodeQueryBuilder> build)
        {
            var query = new Query<PriceRuleDiscountCode>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleDiscountCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleDiscountCode>(query);
            return this;
        }
    }
}