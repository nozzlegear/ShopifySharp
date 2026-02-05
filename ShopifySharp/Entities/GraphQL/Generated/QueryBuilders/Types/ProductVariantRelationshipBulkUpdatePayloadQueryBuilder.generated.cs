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
    public sealed class ProductVariantRelationshipBulkUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<ProductVariantRelationshipBulkUpdatePayload, ProductVariantRelationshipBulkUpdatePayloadQueryBuilder>
    {
        protected override ProductVariantRelationshipBulkUpdatePayloadQueryBuilder Self => this;

        public ProductVariantRelationshipBulkUpdatePayloadQueryBuilder() : this("productVariantRelationshipBulkUpdatePayload")
        {
        }

        public ProductVariantRelationshipBulkUpdatePayloadQueryBuilder(string name) : base(new Query<ProductVariantRelationshipBulkUpdatePayload>(name))
        {
        }

        public ProductVariantRelationshipBulkUpdatePayloadQueryBuilder(IQuery<ProductVariantRelationshipBulkUpdatePayload> query) : base(query)
        {
        }

        public ProductVariantRelationshipBulkUpdatePayloadQueryBuilder ParentProductVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("parentProductVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantRelationshipBulkUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantRelationshipBulkUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductVariantRelationshipBulkUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantRelationshipBulkUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantRelationshipBulkUpdateUserError>(query);
            return this;
        }
    }
}