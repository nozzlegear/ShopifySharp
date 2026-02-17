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
    public sealed class PricingPercentageValueQueryBuilder : FieldsQueryBuilderBase<PricingPercentageValue, PricingPercentageValueQueryBuilder>
    {
        protected override PricingPercentageValueQueryBuilder Self => this;

        public PricingPercentageValueQueryBuilder() : this("pricingPercentageValue")
        {
        }

        public PricingPercentageValueQueryBuilder(string name) : base(new Query<PricingPercentageValue>(name))
        {
        }

        public PricingPercentageValueQueryBuilder(IQuery<PricingPercentageValue> query) : base(query)
        {
        }

        public PricingPercentageValueQueryBuilder Percentage()
        {
            base.InnerQuery.AddField("percentage");
            return this;
        }
    }
}