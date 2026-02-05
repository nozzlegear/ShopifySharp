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
    public sealed class PriceRuleValueUnionCasesBuilder : UnionCasesBuilderBase<PriceRuleValue, PriceRuleValueUnionCasesBuilder>
    {
        protected override PriceRuleValueUnionCasesBuilder Self => this;

        public PriceRuleValueUnionCasesBuilder(string fieldName = "priceRuleValue") : this(new Query<PriceRuleValue>(fieldName))
        {
        }

        public PriceRuleValueUnionCasesBuilder(IQuery<PriceRuleValue> query) : base(query)
        {
        }

        public PriceRuleValueUnionCasesBuilder OnPriceRuleFixedAmountValue(Action<PriceRuleFixedAmountValueQueryBuilder> build)
        {
            var query = new Query<PriceRuleFixedAmountValue>("... on PriceRuleFixedAmountValue");
            var queryBuilder = new PriceRuleFixedAmountValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PriceRuleValueUnionCasesBuilder OnPriceRulePercentValue(Action<PriceRulePercentValueQueryBuilder> build)
        {
            var query = new Query<PriceRulePercentValue>("... on PriceRulePercentValue");
            var queryBuilder = new PriceRulePercentValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}