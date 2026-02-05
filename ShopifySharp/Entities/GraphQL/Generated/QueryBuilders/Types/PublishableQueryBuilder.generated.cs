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
    public sealed class PublishableQueryBuilder : FieldsQueryBuilderBase<IPublishable, PublishableQueryBuilder>
    {
        protected override PublishableQueryBuilder Self => this;

        public PublishableQueryBuilder() : this("publishable")
        {
        }

        public PublishableQueryBuilder(string name) : base(new Query<IPublishable>(name))
        {
        }

        public PublishableQueryBuilder(IQuery<IPublishable> query) : base(query)
        {
        }

        public PublishableQueryBuilder AvailablePublicationsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("availablePublicationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        [Obsolete("Use `resourcePublicationsCount` instead.")]
        public PublishableQueryBuilder PublicationCount()
        {
            base.InnerQuery.AddField("publicationCount");
            return this;
        }

        [Obsolete("Use `publishedOnPublication` instead.")]
        public PublishableQueryBuilder PublishedOnChannel()
        {
            base.InnerQuery.AddField("publishedOnChannel");
            return this;
        }

        [Obsolete("Use `publishedOnCurrentPublication` instead.")]
        public PublishableQueryBuilder PublishedOnCurrentChannel()
        {
            base.InnerQuery.AddField("publishedOnCurrentChannel");
            return this;
        }

        public PublishableQueryBuilder PublishedOnCurrentPublication()
        {
            base.InnerQuery.AddField("publishedOnCurrentPublication");
            return this;
        }

        public PublishableQueryBuilder PublishedOnPublication()
        {
            base.InnerQuery.AddField("publishedOnPublication");
            return this;
        }

        public PublishableQueryBuilder ResourcePublications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationConnection>("resourcePublications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationConnection>(query);
            return this;
        }

        public PublishableQueryBuilder ResourcePublicationsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("resourcePublicationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public PublishableQueryBuilder ResourcePublicationsV2(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationV2ConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2Connection>("resourcePublicationsV2");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationV2ConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2Connection>(query);
            return this;
        }

        public PublishableQueryBuilder UnpublishedChannels(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelConnectionQueryBuilder> build)
        {
            var query = new Query<ChannelConnection>("unpublishedChannels");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelConnection>(query);
            return this;
        }

        public PublishableQueryBuilder UnpublishedPublications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationConnectionQueryBuilder> build)
        {
            var query = new Query<PublicationConnection>("unpublishedPublications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationConnection>(query);
            return this;
        }
    }
}