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
    public sealed class PriceRuleValueUnionCasesBuilder : UnionCasesBuilderBase<PriceRuleValue, PriceRuleValueUnionCasesBuilder>
    {
        protected override PriceRuleValueUnionCasesBuilder Self => this;

        public PriceRuleValueUnionCasesBuilder(string fieldName = "priceRuleValue") : this(new Query<PriceRuleValue>(fieldName))
        {
        }

        public PriceRuleValueUnionCasesBuilder(IQuery<PriceRuleValue> query) : base(query)
        {
        }

        public PriceRuleValueUnionCasesBuilder OnPriceRuleFixedAmountValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleFixedAmountValueQueryBuilder> build)
        {
            var query = new Query<PriceRuleFixedAmountValue>("... on PriceRuleFixedAmountValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleFixedAmountValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PriceRuleValueUnionCasesBuilder OnPriceRulePercentValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceRulePercentValueQueryBuilder> build)
        {
            var query = new Query<PriceRulePercentValue>("... on PriceRulePercentValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceRulePercentValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}