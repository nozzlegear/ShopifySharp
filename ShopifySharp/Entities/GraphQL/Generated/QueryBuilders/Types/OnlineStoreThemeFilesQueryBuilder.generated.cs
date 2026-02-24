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
    public sealed class OnlineStoreThemeFilesQueryBuilder : FieldsQueryBuilderBase<OnlineStoreThemeFileConnection, OnlineStoreThemeFilesQueryBuilder>, IHasArguments<OnlineStoreThemeFilesArgumentsBuilder>
    {
        public OnlineStoreThemeFilesArgumentsBuilder Arguments { get; }
        protected override OnlineStoreThemeFilesQueryBuilder Self => this;

        public OnlineStoreThemeFilesQueryBuilder(string name) : base(new Query<OnlineStoreThemeFileConnection>(name))
        {
            Arguments = new OnlineStoreThemeFilesArgumentsBuilder(base.InnerQuery);
        }

        public OnlineStoreThemeFilesQueryBuilder(IQuery<OnlineStoreThemeFileConnection> query) : base(query)
        {
            Arguments = new OnlineStoreThemeFilesArgumentsBuilder(base.InnerQuery);
        }

        public OnlineStoreThemeFilesQueryBuilder SetArguments(Action<OnlineStoreThemeFilesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OnlineStoreThemeFilesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileEdgeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFileEdge>(query);
            return this;
        }

        public OnlineStoreThemeFilesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFile>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFile>(query);
            return this;
        }

        public OnlineStoreThemeFilesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public OnlineStoreThemeFilesQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileReadResultQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileReadResult>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileReadResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFileReadResult>(query);
            return this;
        }
    }
}