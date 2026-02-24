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
    public sealed class CollectionUnpublishedPublicationsQueryBuilder : FieldsQueryBuilderBase<PublicationConnection, CollectionUnpublishedPublicationsQueryBuilder>, IHasArguments<CollectionUnpublishedPublicationsArgumentsBuilder>
    {
        public CollectionUnpublishedPublicationsArgumentsBuilder Arguments { get; }
        protected override CollectionUnpublishedPublicationsQueryBuilder Self => this;

        public CollectionUnpublishedPublicationsQueryBuilder(string name) : base(new Query<PublicationConnection>(name))
        {
            Arguments = new CollectionUnpublishedPublicationsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionUnpublishedPublicationsQueryBuilder(IQuery<PublicationConnection> query) : base(query)
        {
            Arguments = new CollectionUnpublishedPublicationsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionUnpublishedPublicationsQueryBuilder SetArguments(Action<CollectionUnpublishedPublicationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionUnpublishedPublicationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationEdgeQueryBuilder> build)
        {
            var query = new Query<PublicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationEdge>(query);
            return this;
        }

        public CollectionUnpublishedPublicationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public CollectionUnpublishedPublicationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}