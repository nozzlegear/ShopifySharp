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
    public sealed class ProductVariantsBulkUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductVariantsBulkUpdateUserError, ProductVariantsBulkUpdateUserErrorQueryBuilder>
    {
        protected override ProductVariantsBulkUpdateUserErrorQueryBuilder Self => this;

        public ProductVariantsBulkUpdateUserErrorQueryBuilder() : this("productVariantsBulkUpdateUserError")
        {
        }

        public ProductVariantsBulkUpdateUserErrorQueryBuilder(string name) : base(new Query<ProductVariantsBulkUpdateUserError>(name))
        {
        }

        public ProductVariantsBulkUpdateUserErrorQueryBuilder(IQuery<ProductVariantsBulkUpdateUserError> query) : base(query)
        {
        }

        public ProductVariantsBulkUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductVariantsBulkUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductVariantsBulkUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}