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
    public sealed class MarketPriceInclusionsQueryBuilder : FieldsQueryBuilderBase<MarketPriceInclusions, MarketPriceInclusionsQueryBuilder>
    {
        protected override MarketPriceInclusionsQueryBuilder Self => this;

        public MarketPriceInclusionsQueryBuilder() : this("marketPriceInclusions")
        {
        }

        public MarketPriceInclusionsQueryBuilder(string name) : base(new Query<MarketPriceInclusions>(name))
        {
        }

        public MarketPriceInclusionsQueryBuilder(IQuery<MarketPriceInclusions> query) : base(query)
        {
        }

        public MarketPriceInclusionsQueryBuilder InclusiveDutiesPricingStrategy()
        {
            base.InnerQuery.AddField("inclusiveDutiesPricingStrategy");
            return this;
        }

        public MarketPriceInclusionsQueryBuilder InclusiveTaxPricingStrategy()
        {
            base.InnerQuery.AddField("inclusiveTaxPricingStrategy");
            return this;
        }
    }
}