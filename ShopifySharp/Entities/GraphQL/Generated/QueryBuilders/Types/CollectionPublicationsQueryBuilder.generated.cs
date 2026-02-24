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
    public sealed class CollectionPublicationsQueryBuilder : FieldsQueryBuilderBase<CollectionPublicationConnection, CollectionPublicationsQueryBuilder>, IHasArguments<CollectionPublicationsArgumentsBuilder>
    {
        public CollectionPublicationsArgumentsBuilder Arguments { get; }
        protected override CollectionPublicationsQueryBuilder Self => this;

        public CollectionPublicationsQueryBuilder(string name) : base(new Query<CollectionPublicationConnection>(name))
        {
            Arguments = new CollectionPublicationsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionPublicationsQueryBuilder(IQuery<CollectionPublicationConnection> query) : base(query)
        {
            Arguments = new CollectionPublicationsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionPublicationsQueryBuilder SetArguments(Action<CollectionPublicationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionPublicationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionPublicationEdgeQueryBuilder> build)
        {
            var query = new Query<CollectionPublicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionPublicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionPublicationEdge>(query);
            return this;
        }

        public CollectionPublicationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionPublicationQueryBuilder> build)
        {
            var query = new Query<CollectionPublication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionPublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionPublication>(query);
            return this;
        }

        public CollectionPublicationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}