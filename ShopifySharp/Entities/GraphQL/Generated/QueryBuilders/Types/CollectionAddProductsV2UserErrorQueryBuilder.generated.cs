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
    public sealed class CollectionAddProductsV2UserErrorQueryBuilder : FieldsQueryBuilderBase<CollectionAddProductsV2UserError, CollectionAddProductsV2UserErrorQueryBuilder>
    {
        protected override CollectionAddProductsV2UserErrorQueryBuilder Self => this;

        public CollectionAddProductsV2UserErrorQueryBuilder() : this("collectionAddProductsV2UserError")
        {
        }

        public CollectionAddProductsV2UserErrorQueryBuilder(string name) : base(new Query<CollectionAddProductsV2UserError>(name))
        {
        }

        public CollectionAddProductsV2UserErrorQueryBuilder(IQuery<CollectionAddProductsV2UserError> query) : base(query)
        {
        }

        public CollectionAddProductsV2UserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CollectionAddProductsV2UserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CollectionAddProductsV2UserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}