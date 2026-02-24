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
    public sealed class PublicationProductPublicationsV3QueryBuilder : FieldsQueryBuilderBase<ResourcePublicationConnection, PublicationProductPublicationsV3QueryBuilder>, IHasArguments<PublicationProductPublicationsV3ArgumentsBuilder>
    {
        public PublicationProductPublicationsV3ArgumentsBuilder Arguments { get; }
        protected override PublicationProductPublicationsV3QueryBuilder Self => this;

        public PublicationProductPublicationsV3QueryBuilder(string name) : base(new Query<ResourcePublicationConnection>(name))
        {
            Arguments = new PublicationProductPublicationsV3ArgumentsBuilder(base.InnerQuery);
        }

        public PublicationProductPublicationsV3QueryBuilder(IQuery<ResourcePublicationConnection> query) : base(query)
        {
            Arguments = new PublicationProductPublicationsV3ArgumentsBuilder(base.InnerQuery);
        }

        public PublicationProductPublicationsV3QueryBuilder SetArguments(Action<PublicationProductPublicationsV3ArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PublicationProductPublicationsV3QueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationEdgeQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationEdge>(query);
            return this;
        }

        public PublicationProductPublicationsV3QueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationQueryBuilder> build)
        {
            var query = new Query<ResourcePublication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublication>(query);
            return this;
        }

        public PublicationProductPublicationsV3QueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}