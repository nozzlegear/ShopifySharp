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
    public sealed class PriceRuleQuantityRangeQueryBuilder : FieldsQueryBuilderBase<PriceRuleQuantityRange, PriceRuleQuantityRangeQueryBuilder>
    {
        protected override PriceRuleQuantityRangeQueryBuilder Self => this;

        public PriceRuleQuantityRangeQueryBuilder() : this("priceRuleQuantityRange")
        {
        }

        public PriceRuleQuantityRangeQueryBuilder(string name) : base(new Query<PriceRuleQuantityRange>(name))
        {
        }

        public PriceRuleQuantityRangeQueryBuilder(IQuery<PriceRuleQuantityRange> query) : base(query)
        {
        }

        public PriceRuleQuantityRangeQueryBuilder GreaterThan()
        {
            base.InnerQuery.AddField("greaterThan");
            return this;
        }

        public PriceRuleQuantityRangeQueryBuilder GreaterThanOrEqualTo()
        {
            base.InnerQuery.AddField("greaterThanOrEqualTo");
            return this;
        }

        public PriceRuleQuantityRangeQueryBuilder LessThan()
        {
            base.InnerQuery.AddField("lessThan");
            return this;
        }

        public PriceRuleQuantityRangeQueryBuilder LessThanOrEqualTo()
        {
            base.InnerQuery.AddField("lessThanOrEqualTo");
            return this;
        }
    }
}