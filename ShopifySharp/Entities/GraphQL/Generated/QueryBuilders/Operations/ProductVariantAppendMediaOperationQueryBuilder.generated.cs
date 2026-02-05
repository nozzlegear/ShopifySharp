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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ProductVariantAppendMediaOperationQueryBuilder : FieldsQueryBuilderBase<ProductVariantAppendMediaPayload, ProductVariantAppendMediaOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductVariantAppendMediaPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductVariantAppendMediaArgumentsBuilder Arguments { get; }
        protected override ProductVariantAppendMediaOperationQueryBuilder Self => this;

        public ProductVariantAppendMediaOperationQueryBuilder() : this("productVariantAppendMedia")
        {
        }

        public ProductVariantAppendMediaOperationQueryBuilder(string name) : base(new Query<ProductVariantAppendMediaPayload>(name))
        {
            Arguments = new ProductVariantAppendMediaArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantAppendMediaOperationQueryBuilder(IQuery<ProductVariantAppendMediaPayload> query) : base(query)
        {
            Arguments = new ProductVariantAppendMediaArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantAppendMediaOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductVariantAppendMediaOperationQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantAppendMediaOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaUserErrorQueryBuilder> build)
        {
            var query = new Query<MediaUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaUserError>(query);
            return this;
        }
    }
}