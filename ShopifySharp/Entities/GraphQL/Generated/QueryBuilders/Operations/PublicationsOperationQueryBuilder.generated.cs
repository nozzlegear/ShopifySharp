#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class PublicationsOperationQueryBuilder : FieldsQueryBuilderBase<PublicationConnection, PublicationsOperationQueryBuilder>, IGraphOperationQueryBuilder<PublicationConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public PublicationsArgumentsBuilder Arguments { get; }
        protected override PublicationsOperationQueryBuilder Self => this;

        public PublicationsOperationQueryBuilder() : this("publications")
        {
        }

        public PublicationsOperationQueryBuilder(string name) : base(new Query<PublicationConnection>(name))
        {
            Arguments = new PublicationsArgumentsBuilder(base.InnerQuery);
        }

        public PublicationsOperationQueryBuilder(IQuery<PublicationConnection> query) : base(query)
        {
            Arguments = new PublicationsArgumentsBuilder(base.InnerQuery);
        }

        public PublicationsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationEdgeQueryBuilder> build)
        {
            var query = new Query<PublicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationEdge>(query);
            return this;
        }

        public PublicationsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public PublicationsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}