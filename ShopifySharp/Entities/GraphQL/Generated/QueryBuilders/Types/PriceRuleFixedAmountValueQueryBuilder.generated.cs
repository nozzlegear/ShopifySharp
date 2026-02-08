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
    public sealed class PriceRuleFixedAmountValueQueryBuilder : FieldsQueryBuilderBase<PriceRuleFixedAmountValue, PriceRuleFixedAmountValueQueryBuilder>
    {
        protected override PriceRuleFixedAmountValueQueryBuilder Self => this;

        public PriceRuleFixedAmountValueQueryBuilder() : this("priceRuleFixedAmountValue")
        {
        }

        public PriceRuleFixedAmountValueQueryBuilder(string name) : base(new Query<PriceRuleFixedAmountValue>(name))
        {
        }

        public PriceRuleFixedAmountValueQueryBuilder(IQuery<PriceRuleFixedAmountValue> query) : base(query)
        {
        }

        public PriceRuleFixedAmountValueQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }
    }
}