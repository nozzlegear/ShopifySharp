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
    public sealed class ProductVariantAppendMediaPayloadQueryBuilder : FieldsQueryBuilderBase<ProductVariantAppendMediaPayload, ProductVariantAppendMediaPayloadQueryBuilder>
    {
        protected override ProductVariantAppendMediaPayloadQueryBuilder Self => this;

        public ProductVariantAppendMediaPayloadQueryBuilder() : this("productVariantAppendMediaPayload")
        {
        }

        public ProductVariantAppendMediaPayloadQueryBuilder(string name) : base(new Query<ProductVariantAppendMediaPayload>(name))
        {
        }

        public ProductVariantAppendMediaPayloadQueryBuilder(IQuery<ProductVariantAppendMediaPayload> query) : base(query)
        {
        }

        public ProductVariantAppendMediaPayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductVariantAppendMediaPayloadQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantAppendMediaPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaUserErrorQueryBuilder> build)
        {
            var query = new Query<MediaUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaUserError>(query);
            return this;
        }
    }
}