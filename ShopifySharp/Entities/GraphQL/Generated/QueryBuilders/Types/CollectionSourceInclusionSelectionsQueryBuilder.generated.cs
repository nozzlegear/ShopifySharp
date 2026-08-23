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
    public sealed class CollectionSourceInclusionSelectionsQueryBuilder : FieldsQueryBuilderBase<CollectionInclusionProductSelectionConnection, CollectionSourceInclusionSelectionsQueryBuilder>, IHasArguments<CollectionSourceInclusionSelectionsArgumentsBuilder>
    {
        public CollectionSourceInclusionSelectionsArgumentsBuilder Arguments { get; }
        protected override CollectionSourceInclusionSelectionsQueryBuilder Self => this;

        public CollectionSourceInclusionSelectionsQueryBuilder(string name) : base(new Query<CollectionInclusionProductSelectionConnection>(name))
        {
            Arguments = new CollectionSourceInclusionSelectionsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionSourceInclusionSelectionsQueryBuilder(IQuery<CollectionInclusionProductSelectionConnection> query) : base(query)
        {
            Arguments = new CollectionSourceInclusionSelectionsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionSourceInclusionSelectionsQueryBuilder SetArguments(Action<CollectionSourceInclusionSelectionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionSourceInclusionSelectionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionInclusionProductSelectionEdgeQueryBuilder> build)
        {
            var query = new Query<CollectionInclusionProductSelectionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionInclusionProductSelectionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionInclusionProductSelectionEdge>(query);
            return this;
        }

        public CollectionSourceInclusionSelectionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionInclusionProductSelectionQueryBuilder> build)
        {
            var query = new Query<CollectionInclusionProductSelection>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionInclusionProductSelectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionInclusionProductSelection>(query);
            return this;
        }

        public CollectionSourceInclusionSelectionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}