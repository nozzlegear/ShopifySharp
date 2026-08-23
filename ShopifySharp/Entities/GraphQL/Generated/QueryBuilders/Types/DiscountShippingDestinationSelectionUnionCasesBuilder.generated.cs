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
    public sealed class DiscountShippingDestinationSelectionUnionCasesBuilder : UnionCasesBuilderBase<DiscountShippingDestinationSelection, DiscountShippingDestinationSelectionUnionCasesBuilder>
    {
        protected override DiscountShippingDestinationSelectionUnionCasesBuilder Self => this;

        public DiscountShippingDestinationSelectionUnionCasesBuilder(string fieldName = "discountShippingDestinationSelection") : this(new Query<DiscountShippingDestinationSelection>(fieldName))
        {
        }

        public DiscountShippingDestinationSelectionUnionCasesBuilder(IQuery<DiscountShippingDestinationSelection> query) : base(query)
        {
        }

        public DiscountShippingDestinationSelectionUnionCasesBuilder OnDiscountCountries(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCountriesQueryBuilder> build)
        {
            var query = new Query<DiscountCountries>("... on DiscountCountries");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCountriesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountShippingDestinationSelectionUnionCasesBuilder OnDiscountCountryAll(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCountryAllQueryBuilder> build)
        {
            var query = new Query<DiscountCountryAll>("... on DiscountCountryAll");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCountryAllQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}