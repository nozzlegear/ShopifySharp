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
    public sealed class ProductVariantsBulkDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductVariantsBulkDeleteUserError, ProductVariantsBulkDeleteUserErrorQueryBuilder>
    {
        protected override ProductVariantsBulkDeleteUserErrorQueryBuilder Self => this;

        public ProductVariantsBulkDeleteUserErrorQueryBuilder() : this("productVariantsBulkDeleteUserError")
        {
        }

        public ProductVariantsBulkDeleteUserErrorQueryBuilder(string name) : base(new Query<ProductVariantsBulkDeleteUserError>(name))
        {
        }

        public ProductVariantsBulkDeleteUserErrorQueryBuilder(IQuery<ProductVariantsBulkDeleteUserError> query) : base(query)
        {
        }

        public ProductVariantsBulkDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductVariantsBulkDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductVariantsBulkDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}