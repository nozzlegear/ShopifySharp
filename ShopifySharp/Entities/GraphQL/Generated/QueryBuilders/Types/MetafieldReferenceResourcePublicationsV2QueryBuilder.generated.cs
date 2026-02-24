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
    public sealed class MetafieldReferenceResourcePublicationsV2QueryBuilder : FieldsQueryBuilderBase<ResourcePublicationV2Connection, MetafieldReferenceResourcePublicationsV2QueryBuilder>, IHasArguments<MetafieldReferenceResourcePublicationsV2ArgumentsBuilder>
    {
        public MetafieldReferenceResourcePublicationsV2ArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceResourcePublicationsV2QueryBuilder Self => this;

        public MetafieldReferenceResourcePublicationsV2QueryBuilder(string name) : base(new Query<ResourcePublicationV2Connection>(name))
        {
            Arguments = new MetafieldReferenceResourcePublicationsV2ArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceResourcePublicationsV2QueryBuilder(IQuery<ResourcePublicationV2Connection> query) : base(query)
        {
            Arguments = new MetafieldReferenceResourcePublicationsV2ArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceResourcePublicationsV2QueryBuilder SetArguments(Action<MetafieldReferenceResourcePublicationsV2ArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceResourcePublicationsV2QueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2EdgeQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2Edge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2EdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2Edge>(query);
            return this;
        }

        public MetafieldReferenceResourcePublicationsV2QueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2QueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2>(query);
            return this;
        }

        public MetafieldReferenceResourcePublicationsV2QueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}