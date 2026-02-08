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
    public sealed class CollectionReorderProductsPayloadQueryBuilder : FieldsQueryBuilderBase<CollectionReorderProductsPayload, CollectionReorderProductsPayloadQueryBuilder>
    {
        protected override CollectionReorderProductsPayloadQueryBuilder Self => this;

        public CollectionReorderProductsPayloadQueryBuilder() : this("collectionReorderProductsPayload")
        {
        }

        public CollectionReorderProductsPayloadQueryBuilder(string name) : base(new Query<CollectionReorderProductsPayload>(name))
        {
        }

        public CollectionReorderProductsPayloadQueryBuilder(IQuery<CollectionReorderProductsPayload> query) : base(query)
        {
        }

        public CollectionReorderProductsPayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public CollectionReorderProductsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionReorderProductsUserErrorQueryBuilder> build)
        {
            var query = new Query<CollectionReorderProductsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionReorderProductsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionReorderProductsUserError>(query);
            return this;
        }
    }
}