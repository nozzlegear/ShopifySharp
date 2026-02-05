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
    public sealed class ResourcePublicationV2QueryBuilder : FieldsQueryBuilderBase<ResourcePublicationV2, ResourcePublicationV2QueryBuilder>
    {
        protected override ResourcePublicationV2QueryBuilder Self => this;

        public ResourcePublicationV2QueryBuilder() : this("resourcePublicationV2")
        {
        }

        public ResourcePublicationV2QueryBuilder(string name) : base(new Query<ResourcePublicationV2>(name))
        {
        }

        public ResourcePublicationV2QueryBuilder(IQuery<ResourcePublicationV2> query) : base(query)
        {
        }

        public ResourcePublicationV2QueryBuilder IsPublished()
        {
            base.InnerQuery.AddField("isPublished");
            return this;
        }

        public ResourcePublicationV2QueryBuilder Publication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public ResourcePublicationV2QueryBuilder Publishable(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublishableQueryBuilder> build)
        {
            var query = new Query<IPublishable>("publishable");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublishableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IPublishable>(query);
            return this;
        }

        public ResourcePublicationV2QueryBuilder PublishDate()
        {
            base.InnerQuery.AddField("publishDate");
            return this;
        }
    }
}