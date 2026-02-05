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
    public sealed class ProductVariantsBulkCreatePayloadQueryBuilder : FieldsQueryBuilderBase<ProductVariantsBulkCreatePayload, ProductVariantsBulkCreatePayloadQueryBuilder>
    {
        protected override ProductVariantsBulkCreatePayloadQueryBuilder Self => this;

        public ProductVariantsBulkCreatePayloadQueryBuilder() : this("productVariantsBulkCreatePayload")
        {
        }

        public ProductVariantsBulkCreatePayloadQueryBuilder(string name) : base(new Query<ProductVariantsBulkCreatePayload>(name))
        {
        }

        public ProductVariantsBulkCreatePayloadQueryBuilder(IQuery<ProductVariantsBulkCreatePayload> query) : base(query)
        {
        }

        public ProductVariantsBulkCreatePayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductVariantsBulkCreatePayloadQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantsBulkCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantsBulkCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductVariantsBulkCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantsBulkCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantsBulkCreateUserError>(query);
            return this;
        }
    }
}