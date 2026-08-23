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
    public sealed class CollectionConditionsSourcesByAppConnectionQueryBuilder : FieldsQueryBuilderBase<CollectionConditionsSourcesByAppConnection, CollectionConditionsSourcesByAppConnectionQueryBuilder>, IHasArguments<CollectionConditionsSourcesByAppConnectionArgumentsBuilder>
    {
        public CollectionConditionsSourcesByAppConnectionArgumentsBuilder Arguments { get; }
        protected override CollectionConditionsSourcesByAppConnectionQueryBuilder Self => this;

        public CollectionConditionsSourcesByAppConnectionQueryBuilder() : this("collectionConditionsSourcesByAppConnection")
        {
        }

        public CollectionConditionsSourcesByAppConnectionQueryBuilder(string name) : base(new Query<CollectionConditionsSourcesByAppConnection>(name))
        {
            Arguments = new CollectionConditionsSourcesByAppConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourcesByAppConnectionQueryBuilder(IQuery<CollectionConditionsSourcesByAppConnection> query) : base(query)
        {
            Arguments = new CollectionConditionsSourcesByAppConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourcesByAppConnectionQueryBuilder SetArguments(Action<CollectionConditionsSourcesByAppConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionConditionsSourcesByAppConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppEdgeQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSourcesByAppEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSourcesByAppEdge>(query);
            return this;
        }

        public CollectionConditionsSourcesByAppConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSourcesByApp>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSourcesByApp>(query);
            return this;
        }

        public CollectionConditionsSourcesByAppConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}