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
    public sealed class ShopDraftOrderTagsQueryBuilder : FieldsQueryBuilderBase<StringConnection, ShopDraftOrderTagsQueryBuilder>, IHasArguments<ShopDraftOrderTagsArgumentsBuilder>
    {
        public ShopDraftOrderTagsArgumentsBuilder Arguments { get; }
        protected override ShopDraftOrderTagsQueryBuilder Self => this;

        public ShopDraftOrderTagsQueryBuilder(string name) : base(new Query<StringConnection>(name))
        {
            Arguments = new ShopDraftOrderTagsArgumentsBuilder(base.InnerQuery);
        }

        public ShopDraftOrderTagsQueryBuilder(IQuery<StringConnection> query) : base(query)
        {
            Arguments = new ShopDraftOrderTagsArgumentsBuilder(base.InnerQuery);
        }

        public ShopDraftOrderTagsQueryBuilder SetArguments(Action<ShopDraftOrderTagsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShopDraftOrderTagsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StringEdgeQueryBuilder> build)
        {
            var query = new Query<StringEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StringEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringEdge>(query);
            return this;
        }

        public ShopDraftOrderTagsQueryBuilder Nodes()
        {
            base.InnerQuery.AddField("nodes");
            return this;
        }

        public ShopDraftOrderTagsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}