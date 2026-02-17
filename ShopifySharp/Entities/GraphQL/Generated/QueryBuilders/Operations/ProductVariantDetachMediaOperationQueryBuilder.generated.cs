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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class ProductVariantDetachMediaOperationQueryBuilder : FieldsQueryBuilderBase<ProductVariantDetachMediaPayload, ProductVariantDetachMediaOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductVariantDetachMediaPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductVariantDetachMediaArgumentsBuilder Arguments { get; }
        protected override ProductVariantDetachMediaOperationQueryBuilder Self => this;

        public ProductVariantDetachMediaOperationQueryBuilder() : this("productVariantDetachMedia")
        {
        }

        public ProductVariantDetachMediaOperationQueryBuilder(string name) : base(new Query<ProductVariantDetachMediaPayload>(name))
        {
            Arguments = new ProductVariantDetachMediaArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantDetachMediaOperationQueryBuilder(IQuery<ProductVariantDetachMediaPayload> query) : base(query)
        {
            Arguments = new ProductVariantDetachMediaArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantDetachMediaOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductVariantDetachMediaOperationQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantDetachMediaOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaUserErrorQueryBuilder> build)
        {
            var query = new Query<MediaUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaUserError>(query);
            return this;
        }
    }
}