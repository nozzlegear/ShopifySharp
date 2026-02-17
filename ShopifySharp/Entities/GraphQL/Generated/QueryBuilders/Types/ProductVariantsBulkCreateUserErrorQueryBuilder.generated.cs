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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ProductVariantsBulkCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductVariantsBulkCreateUserError, ProductVariantsBulkCreateUserErrorQueryBuilder>
    {
        protected override ProductVariantsBulkCreateUserErrorQueryBuilder Self => this;

        public ProductVariantsBulkCreateUserErrorQueryBuilder() : this("productVariantsBulkCreateUserError")
        {
        }

        public ProductVariantsBulkCreateUserErrorQueryBuilder(string name) : base(new Query<ProductVariantsBulkCreateUserError>(name))
        {
        }

        public ProductVariantsBulkCreateUserErrorQueryBuilder(IQuery<ProductVariantsBulkCreateUserError> query) : base(query)
        {
        }

        public ProductVariantsBulkCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductVariantsBulkCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductVariantsBulkCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}