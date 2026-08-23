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