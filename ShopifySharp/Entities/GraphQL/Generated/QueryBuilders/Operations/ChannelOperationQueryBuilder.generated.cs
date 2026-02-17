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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class ChannelOperationQueryBuilder : FieldsQueryBuilderBase<Channel, ChannelOperationQueryBuilder>, IGraphOperationQueryBuilder<Channel>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ChannelArgumentsBuilder Arguments { get; }
        protected override ChannelOperationQueryBuilder Self => this;

        public ChannelOperationQueryBuilder() : this("channel")
        {
        }

        public ChannelOperationQueryBuilder(string name) : base(new Query<Channel>(name))
        {
            Arguments = new ChannelArgumentsBuilder(base.InnerQuery);
        }

        public ChannelOperationQueryBuilder(IQuery<Channel> query) : base(query)
        {
            Arguments = new ChannelArgumentsBuilder(base.InnerQuery);
        }

        public ChannelOperationQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public ChannelOperationQueryBuilder CollectionPublicationsV3(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationConnection>("collectionPublicationsV3");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationConnection>(query);
            return this;
        }

        public ChannelOperationQueryBuilder Collections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("collections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public ChannelOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public ChannelOperationQueryBuilder HasCollection()
        {
            base.InnerQuery.AddField("hasCollection");
            return this;
        }

        public ChannelOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ChannelOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ChannelOperationQueryBuilder NavigationItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.NavigationItemQueryBuilder> build)
        {
            var query = new Query<NavigationItem>("navigationItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.NavigationItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<NavigationItem>(query);
            return this;
        }

        [Obsolete("Use [AppInstallation.launchUrl](           https://shopify.dev/api/admin-graphql/current/objects/AppInstallation#field-appinstallation-launchurl) instead.")]
        public ChannelOperationQueryBuilder OverviewPath()
        {
            base.InnerQuery.AddField("overviewPath");
            return this;
        }

        public ChannelOperationQueryBuilder ProductPublications(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ProductPublicationConnection>("productPublications");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublicationConnection>(query);
            return this;
        }

        public ChannelOperationQueryBuilder ProductPublicationsV3(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationConnection>("productPublicationsV3");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationConnection>(query);
            return this;
        }

        public ChannelOperationQueryBuilder Products(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("products");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public ChannelOperationQueryBuilder ProductsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ChannelOperationQueryBuilder SupportsFuturePublishing()
        {
            base.InnerQuery.AddField("supportsFuturePublishing");
            return this;
        }
    }
}