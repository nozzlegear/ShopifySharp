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
    public sealed class ProductVariantsBulkUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ProductVariantsBulkUpdatePayload, ProductVariantsBulkUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductVariantsBulkUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductVariantsBulkUpdateArgumentsBuilder Arguments { get; }
        protected override ProductVariantsBulkUpdateOperationQueryBuilder Self => this;

        public ProductVariantsBulkUpdateOperationQueryBuilder() : this("productVariantsBulkUpdate")
        {
        }

        public ProductVariantsBulkUpdateOperationQueryBuilder(string name) : base(new Query<ProductVariantsBulkUpdatePayload>(name))
        {
            Arguments = new ProductVariantsBulkUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantsBulkUpdateOperationQueryBuilder(IQuery<ProductVariantsBulkUpdatePayload> query) : base(query)
        {
            Arguments = new ProductVariantsBulkUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantsBulkUpdateOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductVariantsBulkUpdateOperationQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantsBulkUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantsBulkUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductVariantsBulkUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantsBulkUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantsBulkUpdateUserError>(query);
            return this;
        }
    }
}