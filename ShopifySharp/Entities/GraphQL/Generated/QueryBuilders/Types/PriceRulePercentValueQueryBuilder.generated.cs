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
    public sealed class PriceRulePercentValueQueryBuilder : FieldsQueryBuilderBase<PriceRulePercentValue, PriceRulePercentValueQueryBuilder>
    {
        protected override PriceRulePercentValueQueryBuilder Self => this;

        public PriceRulePercentValueQueryBuilder() : this("priceRulePercentValue")
        {
        }

        public PriceRulePercentValueQueryBuilder(string name) : base(new Query<PriceRulePercentValue>(name))
        {
        }

        public PriceRulePercentValueQueryBuilder(IQuery<PriceRulePercentValue> query) : base(query)
        {
        }

        public PriceRulePercentValueQueryBuilder Percentage()
        {
            base.InnerQuery.AddField("percentage");
            return this;
        }
    }
}