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
    public sealed class PriceRuleValueQueryBuilder : FieldsQueryBuilderBase<PriceRuleValue, PriceRuleValueQueryBuilder>
    {
        protected override PriceRuleValueQueryBuilder Self => this;

        public PriceRuleValueQueryBuilder() : this("priceRuleValue")
        {
        }

        public PriceRuleValueQueryBuilder(string name) : base(new Query<PriceRuleValue>(name))
        {
        }

        public PriceRuleValueQueryBuilder(IQuery<PriceRuleValue> query) : base(query)
        {
        }

        public PriceRuleValueQueryBuilder PriceRuleValue(Action<PriceRuleValueUnionCasesBuilder> build)
        {
            var query = new Query<PriceRuleValue>("priceRuleValue");
            var unionBuilder = new PriceRuleValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}