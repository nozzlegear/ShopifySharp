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
    public sealed class PriceListFixedPricesByProductUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<PriceListFixedPricesByProductUpdatePayload, PriceListFixedPricesByProductUpdatePayloadQueryBuilder>
    {
        protected override PriceListFixedPricesByProductUpdatePayloadQueryBuilder Self => this;

        public PriceListFixedPricesByProductUpdatePayloadQueryBuilder() : this("priceListFixedPricesByProductUpdatePayload")
        {
        }

        public PriceListFixedPricesByProductUpdatePayloadQueryBuilder(string name) : base(new Query<PriceListFixedPricesByProductUpdatePayload>(name))
        {
        }

        public PriceListFixedPricesByProductUpdatePayloadQueryBuilder(IQuery<PriceListFixedPricesByProductUpdatePayload> query) : base(query)
        {
        }

        public PriceListFixedPricesByProductUpdatePayloadQueryBuilder PriceList(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public PriceListFixedPricesByProductUpdatePayloadQueryBuilder PricesToAddProducts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("pricesToAddProducts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public PriceListFixedPricesByProductUpdatePayloadQueryBuilder PricesToDeleteProducts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("pricesToDeleteProducts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public PriceListFixedPricesByProductUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<PriceListFixedPricesByProductBulkUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListFixedPricesByProductBulkUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListFixedPricesByProductBulkUpdateUserError>(query);
            return this;
        }
    }
}