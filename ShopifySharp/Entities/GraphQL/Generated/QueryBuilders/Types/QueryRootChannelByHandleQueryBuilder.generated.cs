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
    public sealed class QueryRootChannelByHandleQueryBuilder : FieldsQueryBuilderBase<Channel, QueryRootChannelByHandleQueryBuilder>, IHasArguments<QueryRootChannelByHandleArgumentsBuilder>
    {
        public QueryRootChannelByHandleArgumentsBuilder Arguments { get; }
        protected override QueryRootChannelByHandleQueryBuilder Self => this;

        public QueryRootChannelByHandleQueryBuilder(string name) : base(new Query<Channel>(name))
        {
            Arguments = new QueryRootChannelByHandleArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootChannelByHandleQueryBuilder(IQuery<Channel> query) : base(query)
        {
            Arguments = new QueryRootChannelByHandleArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootChannelByHandleQueryBuilder SetArguments(Action<QueryRootChannelByHandleArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder AccountId()
        {
            base.InnerQuery.AddField("accountId");
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder AccountName()
        {
            base.InnerQuery.AddField("accountName");
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder CollectionPublicationsV3(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationConnection>("collectionPublicationsV3");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationConnection>(query);
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder Collections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("collections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder HasCollection()
        {
            base.InnerQuery.AddField("hasCollection");
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder NavigationItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.NavigationItemQueryBuilder> build)
        {
            var query = new Query<NavigationItem>("navigationItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.NavigationItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<NavigationItem>(query);
            return this;
        }

        [Obsolete("Use [AppInstallation.launchUrl](           https://shopify.dev/api/admin-graphql/current/objects/AppInstallation#field-appinstallation-launchurl) instead.")]
        public QueryRootChannelByHandleQueryBuilder OverviewPath()
        {
            base.InnerQuery.AddField("overviewPath");
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder ProductPublications(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ProductPublicationConnection>("productPublications");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublicationConnection>(query);
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder ProductPublicationsV3(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationConnection>("productPublicationsV3");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationConnection>(query);
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder Products(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("products");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder ProductsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder ResourceFeedback(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppFeedbackQueryBuilder> build)
        {
            var query = new Query<AppFeedback>("resourceFeedback");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppFeedback>(query);
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder SpecificationHandle()
        {
            base.InnerQuery.AddField("specificationHandle");
            return this;
        }

        public QueryRootChannelByHandleQueryBuilder SupportsFuturePublishing()
        {
            base.InnerQuery.AddField("supportsFuturePublishing");
            return this;
        }
    }
}