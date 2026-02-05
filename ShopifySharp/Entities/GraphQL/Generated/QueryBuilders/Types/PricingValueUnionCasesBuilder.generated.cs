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
    public sealed class PricingValueUnionCasesBuilder : UnionCasesBuilderBase<PricingValue, PricingValueUnionCasesBuilder>
    {
        protected override PricingValueUnionCasesBuilder Self => this;

        public PricingValueUnionCasesBuilder(string fieldName = "value") : this(new Query<PricingValue>(fieldName))
        {
        }

        public PricingValueUnionCasesBuilder(IQuery<PricingValue> query) : base(query)
        {
        }

        public PricingValueUnionCasesBuilder OnMoneyV2(Action<MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("... on MoneyV2");
            var queryBuilder = new MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PricingValueUnionCasesBuilder OnPricingPercentageValue(Action<PricingPercentageValueQueryBuilder> build)
        {
            var query = new Query<PricingPercentageValue>("... on PricingPercentageValue");
            var queryBuilder = new PricingPercentageValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}