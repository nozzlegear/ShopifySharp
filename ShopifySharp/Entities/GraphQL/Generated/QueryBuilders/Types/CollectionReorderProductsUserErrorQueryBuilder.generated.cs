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
    public sealed class CollectionReorderProductsUserErrorQueryBuilder : FieldsQueryBuilderBase<CollectionReorderProductsUserError, CollectionReorderProductsUserErrorQueryBuilder>
    {
        protected override CollectionReorderProductsUserErrorQueryBuilder Self => this;

        public CollectionReorderProductsUserErrorQueryBuilder() : this("collectionReorderProductsUserError")
        {
        }

        public CollectionReorderProductsUserErrorQueryBuilder(string name) : base(new Query<CollectionReorderProductsUserError>(name))
        {
        }

        public CollectionReorderProductsUserErrorQueryBuilder(IQuery<CollectionReorderProductsUserError> query) : base(query)
        {
        }

        public CollectionReorderProductsUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CollectionReorderProductsUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CollectionReorderProductsUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}