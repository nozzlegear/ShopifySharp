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
    public sealed class PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<PriceListFixedPricesByProductBulkUpdateUserError, PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder>
    {
        protected override PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder Self => this;

        public PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder() : this("priceListFixedPricesByProductBulkUpdateUserError")
        {
        }

        public PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder(string name) : base(new Query<PriceListFixedPricesByProductBulkUpdateUserError>(name))
        {
        }

        public PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder(IQuery<PriceListFixedPricesByProductBulkUpdateUserError> query) : base(query)
        {
        }

        public PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}