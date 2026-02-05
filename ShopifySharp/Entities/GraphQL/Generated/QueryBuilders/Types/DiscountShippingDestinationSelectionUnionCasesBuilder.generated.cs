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
    public sealed class DiscountShippingDestinationSelectionUnionCasesBuilder : UnionCasesBuilderBase<DiscountShippingDestinationSelection, DiscountShippingDestinationSelectionUnionCasesBuilder>
    {
        protected override DiscountShippingDestinationSelectionUnionCasesBuilder Self => this;

        public DiscountShippingDestinationSelectionUnionCasesBuilder(string fieldName = "discountShippingDestinationSelection") : this(new Query<DiscountShippingDestinationSelection>(fieldName))
        {
        }

        public DiscountShippingDestinationSelectionUnionCasesBuilder(IQuery<DiscountShippingDestinationSelection> query) : base(query)
        {
        }

        public DiscountShippingDestinationSelectionUnionCasesBuilder OnDiscountCountries(Action<DiscountCountriesQueryBuilder> build)
        {
            var query = new Query<DiscountCountries>("... on DiscountCountries");
            var queryBuilder = new DiscountCountriesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountShippingDestinationSelectionUnionCasesBuilder OnDiscountCountryAll(Action<DiscountCountryAllQueryBuilder> build)
        {
            var query = new Query<DiscountCountryAll>("... on DiscountCountryAll");
            var queryBuilder = new DiscountCountryAllQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}