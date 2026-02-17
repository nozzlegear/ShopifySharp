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
    public sealed class ResourcePublicationV2EdgeQueryBuilder : FieldsQueryBuilderBase<ResourcePublicationV2Edge, ResourcePublicationV2EdgeQueryBuilder>
    {
        protected override ResourcePublicationV2EdgeQueryBuilder Self => this;

        public ResourcePublicationV2EdgeQueryBuilder() : this("resourcePublicationV2Edge")
        {
        }

        public ResourcePublicationV2EdgeQueryBuilder(string name) : base(new Query<ResourcePublicationV2Edge>(name))
        {
        }

        public ResourcePublicationV2EdgeQueryBuilder(IQuery<ResourcePublicationV2Edge> query) : base(query)
        {
        }

        public ResourcePublicationV2EdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ResourcePublicationV2EdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2QueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2>(query);
            return this;
        }
    }
}