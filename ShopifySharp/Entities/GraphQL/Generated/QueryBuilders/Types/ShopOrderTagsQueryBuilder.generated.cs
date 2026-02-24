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
    public sealed class ShopOrderTagsQueryBuilder : FieldsQueryBuilderBase<StringConnection, ShopOrderTagsQueryBuilder>, IHasArguments<ShopOrderTagsArgumentsBuilder>
    {
        public ShopOrderTagsArgumentsBuilder Arguments { get; }
        protected override ShopOrderTagsQueryBuilder Self => this;

        public ShopOrderTagsQueryBuilder(string name) : base(new Query<StringConnection>(name))
        {
            Arguments = new ShopOrderTagsArgumentsBuilder(base.InnerQuery);
        }

        public ShopOrderTagsQueryBuilder(IQuery<StringConnection> query) : base(query)
        {
            Arguments = new ShopOrderTagsArgumentsBuilder(base.InnerQuery);
        }

        public ShopOrderTagsQueryBuilder SetArguments(Action<ShopOrderTagsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShopOrderTagsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StringEdgeQueryBuilder> build)
        {
            var query = new Query<StringEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StringEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringEdge>(query);
            return this;
        }

        public ShopOrderTagsQueryBuilder Nodes()
        {
            base.InnerQuery.AddField("nodes");
            return this;
        }

        public ShopOrderTagsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}