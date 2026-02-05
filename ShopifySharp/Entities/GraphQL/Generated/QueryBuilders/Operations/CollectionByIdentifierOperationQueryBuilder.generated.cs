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
    public sealed class CollectionByIdentifierOperationQueryBuilder : FieldsQueryBuilderBase<Collection, CollectionByIdentifierOperationQueryBuilder>, IGraphOperationQueryBuilder<Collection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CollectionByIdentifierArgumentsBuilder Arguments { get; }
        protected override CollectionByIdentifierOperationQueryBuilder Self => this;

        public CollectionByIdentifierOperationQueryBuilder() : this("collectionByIdentifier")
        {
        }

        public CollectionByIdentifierOperationQueryBuilder(string name) : base(new Query<Collection>(name))
        {
            Arguments = new CollectionByIdentifierArgumentsBuilder(base.InnerQuery);
        }

        public CollectionByIdentifierOperationQueryBuilder(IQuery<Collection> query) : base(query)
        {
            Arguments = new CollectionByIdentifierArgumentsBuilder(base.InnerQuery);
        }

        public CollectionByIdentifierOperationQueryBuilder ActiveOperations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionOperationsQueryBuilder> build)
        {
            var query = new Query<CollectionOperations>("activeOperations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionOperationsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionOperations>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder AvailablePublicationsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("availablePublicationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder DescriptionHtml()
        {
            base.InnerQuery.AddField("descriptionHtml");
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder Feedback(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceFeedbackQueryBuilder> build)
        {
            var query = new Query<ResourceFeedback>("feedback");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourceFeedback>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder HasProduct()
        {
            base.InnerQuery.AddField("hasProduct");
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder Image(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder Products(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("products");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder ProductsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        [Obsolete("Use `resourcePublicationsCount` instead.")]
        public CollectionByIdentifierOperationQueryBuilder PublicationCount()
        {
            base.InnerQuery.AddField("publicationCount");
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder Publications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionPublicationConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionPublicationConnection>("publications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionPublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionPublicationConnection>(query);
            return this;
        }

        [Obsolete("Use `publishedOnPublication` instead.")]
        public CollectionByIdentifierOperationQueryBuilder PublishedOnChannel()
        {
            base.InnerQuery.AddField("publishedOnChannel");
            return this;
        }

        [Obsolete("Use `publishedOnCurrentPublication` instead.")]
        public CollectionByIdentifierOperationQueryBuilder PublishedOnCurrentChannel()
        {
            base.InnerQuery.AddField("publishedOnCurrentChannel");
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder PublishedOnCurrentPublication()
        {
            base.InnerQuery.AddField("publishedOnCurrentPublication");
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder PublishedOnPublication()
        {
            base.InnerQuery.AddField("publishedOnPublication");
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder ResourcePublications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationConnection>("resourcePublications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationConnection>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder ResourcePublicationsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("resourcePublicationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder ResourcePublicationsV2(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationV2ConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2Connection>("resourcePublicationsV2");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationV2ConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2Connection>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder RuleSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionRuleSetQueryBuilder> build)
        {
            var query = new Query<CollectionRuleSet>("ruleSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionRuleSetQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionRuleSet>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder Seo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SEOQueryBuilder> build)
        {
            var query = new Query<SEO>("seo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SEOQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SEO>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder SortOrder()
        {
            base.InnerQuery.AddField("sortOrder");
            return this;
        }

        [Obsolete("Use `id` instead.")]
        public CollectionByIdentifierOperationQueryBuilder StorefrontId()
        {
            base.InnerQuery.AddField("storefrontId");
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder TemplateSuffix()
        {
            base.InnerQuery.AddField("templateSuffix");
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder UnpublishedChannels(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelConnectionQueryBuilder> build)
        {
            var query = new Query<ChannelConnection>("unpublishedChannels");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelConnection>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder UnpublishedPublications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationConnectionQueryBuilder> build)
        {
            var query = new Query<PublicationConnection>("unpublishedPublications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationConnection>(query);
            return this;
        }

        public CollectionByIdentifierOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}