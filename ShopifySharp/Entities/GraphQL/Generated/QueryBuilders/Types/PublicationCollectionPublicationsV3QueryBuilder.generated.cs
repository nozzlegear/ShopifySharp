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
    public sealed class PublicationCollectionPublicationsV3QueryBuilder : FieldsQueryBuilderBase<ResourcePublicationConnection, PublicationCollectionPublicationsV3QueryBuilder>, IHasArguments<PublicationCollectionPublicationsV3ArgumentsBuilder>
    {
        public PublicationCollectionPublicationsV3ArgumentsBuilder Arguments { get; }
        protected override PublicationCollectionPublicationsV3QueryBuilder Self => this;

        public PublicationCollectionPublicationsV3QueryBuilder(string name) : base(new Query<ResourcePublicationConnection>(name))
        {
            Arguments = new PublicationCollectionPublicationsV3ArgumentsBuilder(base.InnerQuery);
        }

        public PublicationCollectionPublicationsV3QueryBuilder(IQuery<ResourcePublicationConnection> query) : base(query)
        {
            Arguments = new PublicationCollectionPublicationsV3ArgumentsBuilder(base.InnerQuery);
        }

        public PublicationCollectionPublicationsV3QueryBuilder SetArguments(Action<PublicationCollectionPublicationsV3ArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PublicationCollectionPublicationsV3QueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationEdgeQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationEdge>(query);
            return this;
        }

        public PublicationCollectionPublicationsV3QueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationQueryBuilder> build)
        {
            var query = new Query<ResourcePublication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublication>(query);
            return this;
        }

        public PublicationCollectionPublicationsV3QueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}