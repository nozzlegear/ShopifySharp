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
    public sealed class CollectionConditionsSourceConnectionQueryBuilder : FieldsQueryBuilderBase<CollectionConditionsSourceConnection, CollectionConditionsSourceConnectionQueryBuilder>, IHasArguments<CollectionConditionsSourceConnectionArgumentsBuilder>
    {
        public CollectionConditionsSourceConnectionArgumentsBuilder Arguments { get; }
        protected override CollectionConditionsSourceConnectionQueryBuilder Self => this;

        public CollectionConditionsSourceConnectionQueryBuilder() : this("collectionConditionsSourceConnection")
        {
        }

        public CollectionConditionsSourceConnectionQueryBuilder(string name) : base(new Query<CollectionConditionsSourceConnection>(name))
        {
            Arguments = new CollectionConditionsSourceConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourceConnectionQueryBuilder(IQuery<CollectionConditionsSourceConnection> query) : base(query)
        {
            Arguments = new CollectionConditionsSourceConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourceConnectionQueryBuilder SetArguments(Action<CollectionConditionsSourceConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionConditionsSourceConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceEdgeQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSourceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSourceEdge>(query);
            return this;
        }

        public CollectionConditionsSourceConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSource>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSource>(query);
            return this;
        }

        public CollectionConditionsSourceConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}