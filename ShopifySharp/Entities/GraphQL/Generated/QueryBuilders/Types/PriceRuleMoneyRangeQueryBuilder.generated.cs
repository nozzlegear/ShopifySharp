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
    public sealed class PriceRuleMoneyRangeQueryBuilder : FieldsQueryBuilderBase<PriceRuleMoneyRange, PriceRuleMoneyRangeQueryBuilder>
    {
        protected override PriceRuleMoneyRangeQueryBuilder Self => this;

        public PriceRuleMoneyRangeQueryBuilder() : this("priceRuleMoneyRange")
        {
        }

        public PriceRuleMoneyRangeQueryBuilder(string name) : base(new Query<PriceRuleMoneyRange>(name))
        {
        }

        public PriceRuleMoneyRangeQueryBuilder(IQuery<PriceRuleMoneyRange> query) : base(query)
        {
        }

        public PriceRuleMoneyRangeQueryBuilder GreaterThan()
        {
            base.InnerQuery.AddField("greaterThan");
            return this;
        }

        public PriceRuleMoneyRangeQueryBuilder GreaterThanOrEqualTo()
        {
            base.InnerQuery.AddField("greaterThanOrEqualTo");
            return this;
        }

        public PriceRuleMoneyRangeQueryBuilder LessThan()
        {
            base.InnerQuery.AddField("lessThan");
            return this;
        }

        public PriceRuleMoneyRangeQueryBuilder LessThanOrEqualTo()
        {
            base.InnerQuery.AddField("lessThanOrEqualTo");
            return this;
        }
    }
}