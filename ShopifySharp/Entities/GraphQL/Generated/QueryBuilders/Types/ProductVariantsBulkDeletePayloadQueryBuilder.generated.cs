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
    public sealed class ProductVariantsBulkDeletePayloadQueryBuilder : FieldsQueryBuilderBase<ProductVariantsBulkDeletePayload, ProductVariantsBulkDeletePayloadQueryBuilder>
    {
        protected override ProductVariantsBulkDeletePayloadQueryBuilder Self => this;

        public ProductVariantsBulkDeletePayloadQueryBuilder() : this("productVariantsBulkDeletePayload")
        {
        }

        public ProductVariantsBulkDeletePayloadQueryBuilder(string name) : base(new Query<ProductVariantsBulkDeletePayload>(name))
        {
        }

        public ProductVariantsBulkDeletePayloadQueryBuilder(IQuery<ProductVariantsBulkDeletePayload> query) : base(query)
        {
        }

        public ProductVariantsBulkDeletePayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductVariantsBulkDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantsBulkDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductVariantsBulkDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantsBulkDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantsBulkDeleteUserError>(query);
            return this;
        }
    }
}