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
    public sealed class CollectionSourceQueryBuilder : FieldsQueryBuilderBase<ICollectionSource, CollectionSourceQueryBuilder>
    {
        protected override CollectionSourceQueryBuilder Self => this;

        public CollectionSourceQueryBuilder() : this("collectionSource")
        {
        }

        public CollectionSourceQueryBuilder(string name) : base(new Query<ICollectionSource>(name))
        {
        }

        public CollectionSourceQueryBuilder(IQuery<ICollectionSource> query) : base(query)
        {
        }

        public CollectionSourceQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public CollectionSourceQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public CollectionSourceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public CollectionSourceQueryBuilder OnCollectionConditionsSource(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSource>("... on CollectionConditionsSource");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceQueryBuilder OnCollectionSubCollectionsSource(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSubCollectionsSourceQueryBuilder> build)
        {
            var query = new Query<CollectionSubCollectionsSource>("... on CollectionSubCollectionsSource");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSubCollectionsSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceQueryBuilder CollectionSource(Action<CollectionSourceInterfaceCasesBuilder> build)
        {
            var query = new Query<ICollectionSource>("collectionSource");
            var unionBuilder = new CollectionSourceInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}