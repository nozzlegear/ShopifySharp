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
    public sealed class ProductVariantsBulkDeleteOperationQueryBuilder : FieldsQueryBuilderBase<ProductVariantsBulkDeletePayload, ProductVariantsBulkDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductVariantsBulkDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductVariantsBulkDeleteArgumentsBuilder Arguments { get; }
        protected override ProductVariantsBulkDeleteOperationQueryBuilder Self => this;

        public ProductVariantsBulkDeleteOperationQueryBuilder() : this("productVariantsBulkDelete")
        {
        }

        public ProductVariantsBulkDeleteOperationQueryBuilder(string name) : base(new Query<ProductVariantsBulkDeletePayload>(name))
        {
            Arguments = new ProductVariantsBulkDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantsBulkDeleteOperationQueryBuilder(IQuery<ProductVariantsBulkDeletePayload> query) : base(query)
        {
            Arguments = new ProductVariantsBulkDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantsBulkDeleteOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductVariantsBulkDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantsBulkDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductVariantsBulkDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantsBulkDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantsBulkDeleteUserError>(query);
            return this;
        }
    }
}