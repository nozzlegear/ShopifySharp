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
    public sealed class MetafieldReferenceMediaQueryBuilder : FieldsQueryBuilderBase<MediaConnection, MetafieldReferenceMediaQueryBuilder>, IHasArguments<MetafieldReferenceMediaArgumentsBuilder>
    {
        public MetafieldReferenceMediaArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceMediaQueryBuilder Self => this;

        public MetafieldReferenceMediaQueryBuilder(string name) : base(new Query<MediaConnection>(name))
        {
            Arguments = new MetafieldReferenceMediaArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceMediaQueryBuilder(IQuery<MediaConnection> query) : base(query)
        {
            Arguments = new MetafieldReferenceMediaArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceMediaQueryBuilder SetArguments(Action<MetafieldReferenceMediaArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceMediaQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaEdgeQueryBuilder> build)
        {
            var query = new Query<MediaEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaEdge>(query);
            return this;
        }

        public MetafieldReferenceMediaQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaQueryBuilder> build)
        {
            var query = new Query<IMedia>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMedia>(query);
            return this;
        }

        public MetafieldReferenceMediaQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}