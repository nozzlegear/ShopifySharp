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
    public sealed class ProductVariantsBulkUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<ProductVariantsBulkUpdatePayload, ProductVariantsBulkUpdatePayloadQueryBuilder>
    {
        protected override ProductVariantsBulkUpdatePayloadQueryBuilder Self => this;

        public ProductVariantsBulkUpdatePayloadQueryBuilder() : this("productVariantsBulkUpdatePayload")
        {
        }

        public ProductVariantsBulkUpdatePayloadQueryBuilder(string name) : base(new Query<ProductVariantsBulkUpdatePayload>(name))
        {
        }

        public ProductVariantsBulkUpdatePayloadQueryBuilder(IQuery<ProductVariantsBulkUpdatePayload> query) : base(query)
        {
        }

        public ProductVariantsBulkUpdatePayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductVariantsBulkUpdatePayloadQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantsBulkUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantsBulkUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductVariantsBulkUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantsBulkUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantsBulkUpdateUserError>(query);
            return this;
        }
    }
}