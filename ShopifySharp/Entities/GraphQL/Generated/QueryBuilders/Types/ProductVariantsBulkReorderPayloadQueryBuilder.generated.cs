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
    public sealed class ProductVariantsBulkReorderPayloadQueryBuilder : FieldsQueryBuilderBase<ProductVariantsBulkReorderPayload, ProductVariantsBulkReorderPayloadQueryBuilder>
    {
        protected override ProductVariantsBulkReorderPayloadQueryBuilder Self => this;

        public ProductVariantsBulkReorderPayloadQueryBuilder() : this("productVariantsBulkReorderPayload")
        {
        }

        public ProductVariantsBulkReorderPayloadQueryBuilder(string name) : base(new Query<ProductVariantsBulkReorderPayload>(name))
        {
        }

        public ProductVariantsBulkReorderPayloadQueryBuilder(IQuery<ProductVariantsBulkReorderPayload> query) : base(query)
        {
        }

        public ProductVariantsBulkReorderPayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductVariantsBulkReorderPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantsBulkReorderUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductVariantsBulkReorderUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantsBulkReorderUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantsBulkReorderUserError>(query);
            return this;
        }
    }
}