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
    public sealed class CollectionDuplicateUserErrorQueryBuilder : FieldsQueryBuilderBase<CollectionDuplicateUserError, CollectionDuplicateUserErrorQueryBuilder>
    {
        protected override CollectionDuplicateUserErrorQueryBuilder Self => this;

        public CollectionDuplicateUserErrorQueryBuilder() : this("collectionDuplicateUserError")
        {
        }

        public CollectionDuplicateUserErrorQueryBuilder(string name) : base(new Query<CollectionDuplicateUserError>(name))
        {
        }

        public CollectionDuplicateUserErrorQueryBuilder(IQuery<CollectionDuplicateUserError> query) : base(query)
        {
        }

        public CollectionDuplicateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CollectionDuplicateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CollectionDuplicateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}