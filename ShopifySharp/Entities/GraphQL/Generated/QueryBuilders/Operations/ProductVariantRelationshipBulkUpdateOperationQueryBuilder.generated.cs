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
    public sealed class ProductVariantRelationshipBulkUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ProductVariantRelationshipBulkUpdatePayload, ProductVariantRelationshipBulkUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductVariantRelationshipBulkUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductVariantRelationshipBulkUpdateArgumentsBuilder Arguments { get; }
        protected override ProductVariantRelationshipBulkUpdateOperationQueryBuilder Self => this;

        public ProductVariantRelationshipBulkUpdateOperationQueryBuilder() : this("productVariantRelationshipBulkUpdate")
        {
        }

        public ProductVariantRelationshipBulkUpdateOperationQueryBuilder(string name) : base(new Query<ProductVariantRelationshipBulkUpdatePayload>(name))
        {
            Arguments = new ProductVariantRelationshipBulkUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantRelationshipBulkUpdateOperationQueryBuilder(IQuery<ProductVariantRelationshipBulkUpdatePayload> query) : base(query)
        {
            Arguments = new ProductVariantRelationshipBulkUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantRelationshipBulkUpdateOperationQueryBuilder ParentProductVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("parentProductVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantRelationshipBulkUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantRelationshipBulkUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductVariantRelationshipBulkUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantRelationshipBulkUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantRelationshipBulkUpdateUserError>(query);
            return this;
        }
    }
}