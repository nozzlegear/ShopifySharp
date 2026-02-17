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
    public sealed class DiscountCountryAllQueryBuilder : FieldsQueryBuilderBase<DiscountCountryAll, DiscountCountryAllQueryBuilder>
    {
        protected override DiscountCountryAllQueryBuilder Self => this;

        public DiscountCountryAllQueryBuilder() : this("discountCountryAll")
        {
        }

        public DiscountCountryAllQueryBuilder(string name) : base(new Query<DiscountCountryAll>(name))
        {
        }

        public DiscountCountryAllQueryBuilder(IQuery<DiscountCountryAll> query) : base(query)
        {
        }

        public DiscountCountryAllQueryBuilder AllCountries()
        {
            base.InnerQuery.AddField("allCountries");
            return this;
        }
    }
}