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
    public sealed class ProductBundleMutationUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductBundleMutationUserError, ProductBundleMutationUserErrorQueryBuilder>
    {
        protected override ProductBundleMutationUserErrorQueryBuilder Self => this;

        public ProductBundleMutationUserErrorQueryBuilder() : this("productBundleMutationUserError")
        {
        }

        public ProductBundleMutationUserErrorQueryBuilder(string name) : base(new Query<ProductBundleMutationUserError>(name))
        {
        }

        public ProductBundleMutationUserErrorQueryBuilder(IQuery<ProductBundleMutationUserError> query) : base(query)
        {
        }

        public ProductBundleMutationUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductBundleMutationUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductBundleMutationUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}