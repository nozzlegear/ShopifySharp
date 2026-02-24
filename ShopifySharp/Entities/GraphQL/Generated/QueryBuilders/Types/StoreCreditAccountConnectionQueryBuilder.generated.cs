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
    public sealed class StoreCreditAccountConnectionQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountConnection, StoreCreditAccountConnectionQueryBuilder>, IHasArguments<StoreCreditAccountConnectionArgumentsBuilder>
    {
        public StoreCreditAccountConnectionArgumentsBuilder Arguments { get; }
        protected override StoreCreditAccountConnectionQueryBuilder Self => this;

        public StoreCreditAccountConnectionQueryBuilder() : this("storeCreditAccountConnection")
        {
        }

        public StoreCreditAccountConnectionQueryBuilder(string name) : base(new Query<StoreCreditAccountConnection>(name))
        {
            Arguments = new StoreCreditAccountConnectionArgumentsBuilder(base.InnerQuery);
        }

        public StoreCreditAccountConnectionQueryBuilder(IQuery<StoreCreditAccountConnection> query) : base(query)
        {
            Arguments = new StoreCreditAccountConnectionArgumentsBuilder(base.InnerQuery);
        }

        public StoreCreditAccountConnectionQueryBuilder SetArguments(Action<StoreCreditAccountConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public StoreCreditAccountConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountEdgeQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountEdge>(query);
            return this;
        }

        public StoreCreditAccountConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccount>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccount>(query);
            return this;
        }

        public StoreCreditAccountConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}