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
    public sealed class CollectionSubCollectionsSourceQueryBuilder : FieldsQueryBuilderBase<CollectionSubCollectionsSource, CollectionSubCollectionsSourceQueryBuilder>
    {
        protected override CollectionSubCollectionsSourceQueryBuilder Self => this;

        public CollectionSubCollectionsSourceQueryBuilder() : this("collectionSubCollectionsSource")
        {
        }

        public CollectionSubCollectionsSourceQueryBuilder(string name) : base(new Query<CollectionSubCollectionsSource>(name))
        {
        }

        public CollectionSubCollectionsSourceQueryBuilder(IQuery<CollectionSubCollectionsSource> query) : base(query)
        {
        }

        public CollectionSubCollectionsSourceQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public CollectionSubCollectionsSourceQueryBuilder Collections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("collections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public CollectionSubCollectionsSourceQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public CollectionSubCollectionsSourceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSubCollectionsSourceQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}