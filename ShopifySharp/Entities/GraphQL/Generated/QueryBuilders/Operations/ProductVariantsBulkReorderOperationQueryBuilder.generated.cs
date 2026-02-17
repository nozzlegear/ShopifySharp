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
    public sealed class ProductVariantsBulkReorderOperationQueryBuilder : FieldsQueryBuilderBase<ProductVariantsBulkReorderPayload, ProductVariantsBulkReorderOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductVariantsBulkReorderPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductVariantsBulkReorderArgumentsBuilder Arguments { get; }
        protected override ProductVariantsBulkReorderOperationQueryBuilder Self => this;

        public ProductVariantsBulkReorderOperationQueryBuilder() : this("productVariantsBulkReorder")
        {
        }

        public ProductVariantsBulkReorderOperationQueryBuilder(string name) : base(new Query<ProductVariantsBulkReorderPayload>(name))
        {
            Arguments = new ProductVariantsBulkReorderArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantsBulkReorderOperationQueryBuilder(IQuery<ProductVariantsBulkReorderPayload> query) : base(query)
        {
            Arguments = new ProductVariantsBulkReorderArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantsBulkReorderOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductVariantsBulkReorderOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantsBulkReorderUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductVariantsBulkReorderUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantsBulkReorderUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantsBulkReorderUserError>(query);
            return this;
        }
    }
}