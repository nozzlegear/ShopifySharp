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
    public sealed class CollectionExclusionProductSelectionConnectionQueryBuilder : FieldsQueryBuilderBase<CollectionExclusionProductSelectionConnection, CollectionExclusionProductSelectionConnectionQueryBuilder>, IHasArguments<CollectionExclusionProductSelectionConnectionArgumentsBuilder>
    {
        public CollectionExclusionProductSelectionConnectionArgumentsBuilder Arguments { get; }
        protected override CollectionExclusionProductSelectionConnectionQueryBuilder Self => this;

        public CollectionExclusionProductSelectionConnectionQueryBuilder() : this("collectionExclusionProductSelectionConnection")
        {
        }

        public CollectionExclusionProductSelectionConnectionQueryBuilder(string name) : base(new Query<CollectionExclusionProductSelectionConnection>(name))
        {
            Arguments = new CollectionExclusionProductSelectionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CollectionExclusionProductSelectionConnectionQueryBuilder(IQuery<CollectionExclusionProductSelectionConnection> query) : base(query)
        {
            Arguments = new CollectionExclusionProductSelectionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CollectionExclusionProductSelectionConnectionQueryBuilder SetArguments(Action<CollectionExclusionProductSelectionConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionExclusionProductSelectionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionExclusionProductSelectionEdgeQueryBuilder> build)
        {
            var query = new Query<CollectionExclusionProductSelectionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionExclusionProductSelectionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionExclusionProductSelectionEdge>(query);
            return this;
        }

        public CollectionExclusionProductSelectionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionExclusionProductSelectionQueryBuilder> build)
        {
            var query = new Query<CollectionExclusionProductSelection>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionExclusionProductSelectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionExclusionProductSelection>(query);
            return this;
        }

        public CollectionExclusionProductSelectionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}