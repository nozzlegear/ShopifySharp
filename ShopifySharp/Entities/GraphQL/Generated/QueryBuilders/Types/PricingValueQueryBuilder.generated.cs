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
    public sealed class PricingValueQueryBuilder : FieldsQueryBuilderBase<PricingValue, PricingValueQueryBuilder>
    {
        protected override PricingValueQueryBuilder Self => this;

        public PricingValueQueryBuilder() : this("pricingValue")
        {
        }

        public PricingValueQueryBuilder(string name) : base(new Query<PricingValue>(name))
        {
        }

        public PricingValueQueryBuilder(IQuery<PricingValue> query) : base(query)
        {
        }

        public PricingValueQueryBuilder PricingValue(Action<PricingValueUnionCasesBuilder> build)
        {
            var query = new Query<PricingValue>("pricingValue");
            var unionBuilder = new PricingValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}