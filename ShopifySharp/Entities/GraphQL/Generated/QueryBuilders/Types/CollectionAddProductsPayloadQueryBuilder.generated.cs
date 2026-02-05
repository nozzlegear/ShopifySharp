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
    public sealed class CollectionAddProductsPayloadQueryBuilder : FieldsQueryBuilderBase<CollectionAddProductsPayload, CollectionAddProductsPayloadQueryBuilder>
    {
        protected override CollectionAddProductsPayloadQueryBuilder Self => this;

        public CollectionAddProductsPayloadQueryBuilder() : this("collectionAddProductsPayload")
        {
        }

        public CollectionAddProductsPayloadQueryBuilder(string name) : base(new Query<CollectionAddProductsPayload>(name))
        {
        }

        public CollectionAddProductsPayloadQueryBuilder(IQuery<CollectionAddProductsPayload> query) : base(query)
        {
        }

        public CollectionAddProductsPayloadQueryBuilder Collection(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("collection");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public CollectionAddProductsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}