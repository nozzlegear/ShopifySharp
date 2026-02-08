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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class PublicationEdgeQueryBuilder : FieldsQueryBuilderBase<PublicationEdge, PublicationEdgeQueryBuilder>
    {
        protected override PublicationEdgeQueryBuilder Self => this;

        public PublicationEdgeQueryBuilder() : this("publicationEdge")
        {
        }

        public PublicationEdgeQueryBuilder(string name) : base(new Query<PublicationEdge>(name))
        {
        }

        public PublicationEdgeQueryBuilder(IQuery<PublicationEdge> query) : base(query)
        {
        }

        public PublicationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public PublicationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }
    }
}