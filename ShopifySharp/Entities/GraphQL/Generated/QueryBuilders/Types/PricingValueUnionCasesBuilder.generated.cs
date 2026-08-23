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
    public sealed class PricingValueUnionCasesBuilder : UnionCasesBuilderBase<PricingValue, PricingValueUnionCasesBuilder>
    {
        protected override PricingValueUnionCasesBuilder Self => this;

        public PricingValueUnionCasesBuilder(string fieldName = "value") : this(new Query<PricingValue>(fieldName))
        {
        }

        public PricingValueUnionCasesBuilder(IQuery<PricingValue> query) : base(query)
        {
        }

        public PricingValueUnionCasesBuilder OnMoneyV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("... on MoneyV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PricingValueUnionCasesBuilder OnPricingPercentageValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PricingPercentageValueQueryBuilder> build)
        {
            var query = new Query<PricingPercentageValue>("... on PricingPercentageValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PricingPercentageValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}