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
    public sealed class CollectionConditionsSourcesByAppQueryBuilder : FieldsQueryBuilderBase<CollectionConditionsSourcesByApp, CollectionConditionsSourcesByAppQueryBuilder>
    {
        protected override CollectionConditionsSourcesByAppQueryBuilder Self => this;

        public CollectionConditionsSourcesByAppQueryBuilder() : this("collectionConditionsSourcesByApp")
        {
        }

        public CollectionConditionsSourcesByAppQueryBuilder(string name) : base(new Query<CollectionConditionsSourcesByApp>(name))
        {
        }

        public CollectionConditionsSourcesByAppQueryBuilder(IQuery<CollectionConditionsSourcesByApp> query) : base(query)
        {
        }

        public CollectionConditionsSourcesByAppQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public CollectionConditionsSourcesByAppQueryBuilder Sources(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSourceConnection>("sources");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSourceConnection>(query);
            return this;
        }
    }
}