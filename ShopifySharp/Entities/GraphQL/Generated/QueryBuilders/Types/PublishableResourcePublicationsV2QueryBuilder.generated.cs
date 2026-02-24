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
    public sealed class PublishableResourcePublicationsV2QueryBuilder : FieldsQueryBuilderBase<ResourcePublicationV2Connection, PublishableResourcePublicationsV2QueryBuilder>, IHasArguments<PublishableResourcePublicationsV2ArgumentsBuilder>
    {
        public PublishableResourcePublicationsV2ArgumentsBuilder Arguments { get; }
        protected override PublishableResourcePublicationsV2QueryBuilder Self => this;

        public PublishableResourcePublicationsV2QueryBuilder(string name) : base(new Query<ResourcePublicationV2Connection>(name))
        {
            Arguments = new PublishableResourcePublicationsV2ArgumentsBuilder(base.InnerQuery);
        }

        public PublishableResourcePublicationsV2QueryBuilder(IQuery<ResourcePublicationV2Connection> query) : base(query)
        {
            Arguments = new PublishableResourcePublicationsV2ArgumentsBuilder(base.InnerQuery);
        }

        public PublishableResourcePublicationsV2QueryBuilder SetArguments(Action<PublishableResourcePublicationsV2ArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PublishableResourcePublicationsV2QueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2EdgeQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2Edge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2EdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2Edge>(query);
            return this;
        }

        public PublishableResourcePublicationsV2QueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2QueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2>(query);
            return this;
        }

        public PublishableResourcePublicationsV2QueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}