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
    public sealed class DiscountCountriesQueryBuilder : FieldsQueryBuilderBase<DiscountCountries, DiscountCountriesQueryBuilder>
    {
        protected override DiscountCountriesQueryBuilder Self => this;

        public DiscountCountriesQueryBuilder() : this("discountCountries")
        {
        }

        public DiscountCountriesQueryBuilder(string name) : base(new Query<DiscountCountries>(name))
        {
        }

        public DiscountCountriesQueryBuilder(IQuery<DiscountCountries> query) : base(query)
        {
        }

        public DiscountCountriesQueryBuilder Countries()
        {
            base.InnerQuery.AddField("countries");
            return this;
        }

        public DiscountCountriesQueryBuilder IncludeRestOfWorld()
        {
            base.InnerQuery.AddField("includeRestOfWorld");
            return this;
        }
    }
}