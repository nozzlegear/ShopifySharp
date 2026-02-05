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
    public sealed class ProductVariantRelationshipBulkUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductVariantRelationshipBulkUpdateUserError, ProductVariantRelationshipBulkUpdateUserErrorQueryBuilder>
    {
        protected override ProductVariantRelationshipBulkUpdateUserErrorQueryBuilder Self => this;

        public ProductVariantRelationshipBulkUpdateUserErrorQueryBuilder() : this("productVariantRelationshipBulkUpdateUserError")
        {
        }

        public ProductVariantRelationshipBulkUpdateUserErrorQueryBuilder(string name) : base(new Query<ProductVariantRelationshipBulkUpdateUserError>(name))
        {
        }

        public ProductVariantRelationshipBulkUpdateUserErrorQueryBuilder(IQuery<ProductVariantRelationshipBulkUpdateUserError> query) : base(query)
        {
        }

        public ProductVariantRelationshipBulkUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductVariantRelationshipBulkUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductVariantRelationshipBulkUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}