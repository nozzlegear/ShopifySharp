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
    public sealed class CollectionSourceExclusionSelectionsQueryBuilder : FieldsQueryBuilderBase<CollectionExclusionProductSelectionConnection, CollectionSourceExclusionSelectionsQueryBuilder>, IHasArguments<CollectionSourceExclusionSelectionsArgumentsBuilder>
    {
        public CollectionSourceExclusionSelectionsArgumentsBuilder Arguments { get; }
        protected override CollectionSourceExclusionSelectionsQueryBuilder Self => this;

        public CollectionSourceExclusionSelectionsQueryBuilder(string name) : base(new Query<CollectionExclusionProductSelectionConnection>(name))
        {
            Arguments = new CollectionSourceExclusionSelectionsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionSourceExclusionSelectionsQueryBuilder(IQuery<CollectionExclusionProductSelectionConnection> query) : base(query)
        {
            Arguments = new CollectionSourceExclusionSelectionsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionSourceExclusionSelectionsQueryBuilder SetArguments(Action<CollectionSourceExclusionSelectionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionSourceExclusionSelectionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionExclusionProductSelectionEdgeQueryBuilder> build)
        {
            var query = new Query<CollectionExclusionProductSelectionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionExclusionProductSelectionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionExclusionProductSelectionEdge>(query);
            return this;
        }

        public CollectionSourceExclusionSelectionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionExclusionProductSelectionQueryBuilder> build)
        {
            var query = new Query<CollectionExclusionProductSelection>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionExclusionProductSelectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionExclusionProductSelection>(query);
            return this;
        }

        public CollectionSourceExclusionSelectionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}