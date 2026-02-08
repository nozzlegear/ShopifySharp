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
    public sealed class ResourcePublicationEdgeQueryBuilder : FieldsQueryBuilderBase<ResourcePublicationEdge, ResourcePublicationEdgeQueryBuilder>
    {
        protected override ResourcePublicationEdgeQueryBuilder Self => this;

        public ResourcePublicationEdgeQueryBuilder() : this("resourcePublicationEdge")
        {
        }

        public ResourcePublicationEdgeQueryBuilder(string name) : base(new Query<ResourcePublicationEdge>(name))
        {
        }

        public ResourcePublicationEdgeQueryBuilder(IQuery<ResourcePublicationEdge> query) : base(query)
        {
        }

        public ResourcePublicationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ResourcePublicationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationQueryBuilder> build)
        {
            var query = new Query<ResourcePublication>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublication>(query);
            return this;
        }
    }
}