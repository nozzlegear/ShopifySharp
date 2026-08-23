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
    public sealed class CollectionInclusionProductSelectionConnectionQueryBuilder : FieldsQueryBuilderBase<CollectionInclusionProductSelectionConnection, CollectionInclusionProductSelectionConnectionQueryBuilder>, IHasArguments<CollectionInclusionProductSelectionConnectionArgumentsBuilder>
    {
        public CollectionInclusionProductSelectionConnectionArgumentsBuilder Arguments { get; }
        protected override CollectionInclusionProductSelectionConnectionQueryBuilder Self => this;

        public CollectionInclusionProductSelectionConnectionQueryBuilder() : this("collectionInclusionProductSelectionConnection")
        {
        }

        public CollectionInclusionProductSelectionConnectionQueryBuilder(string name) : base(new Query<CollectionInclusionProductSelectionConnection>(name))
        {
            Arguments = new CollectionInclusionProductSelectionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CollectionInclusionProductSelectionConnectionQueryBuilder(IQuery<CollectionInclusionProductSelectionConnection> query) : base(query)
        {
            Arguments = new CollectionInclusionProductSelectionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CollectionInclusionProductSelectionConnectionQueryBuilder SetArguments(Action<CollectionInclusionProductSelectionConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionInclusionProductSelectionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionInclusionProductSelectionEdgeQueryBuilder> build)
        {
            var query = new Query<CollectionInclusionProductSelectionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionInclusionProductSelectionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionInclusionProductSelectionEdge>(query);
            return this;
        }

        public CollectionInclusionProductSelectionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionInclusionProductSelectionQueryBuilder> build)
        {
            var query = new Query<CollectionInclusionProductSelection>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionInclusionProductSelectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionInclusionProductSelection>(query);
            return this;
        }

        public CollectionInclusionProductSelectionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}