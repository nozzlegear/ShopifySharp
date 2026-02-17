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

        public PublicationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }
    }
}