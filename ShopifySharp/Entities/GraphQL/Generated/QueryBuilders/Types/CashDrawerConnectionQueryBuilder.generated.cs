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
    public sealed class CashDrawerConnectionQueryBuilder : FieldsQueryBuilderBase<CashDrawerConnection, CashDrawerConnectionQueryBuilder>, IHasArguments<CashDrawerConnectionArgumentsBuilder>
    {
        public CashDrawerConnectionArgumentsBuilder Arguments { get; }
        protected override CashDrawerConnectionQueryBuilder Self => this;

        public CashDrawerConnectionQueryBuilder() : this("cashDrawerConnection")
        {
        }

        public CashDrawerConnectionQueryBuilder(string name) : base(new Query<CashDrawerConnection>(name))
        {
            Arguments = new CashDrawerConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerConnectionQueryBuilder(IQuery<CashDrawerConnection> query) : base(query)
        {
            Arguments = new CashDrawerConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerConnectionQueryBuilder SetArguments(Action<CashDrawerConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashDrawerConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerEdgeQueryBuilder> build)
        {
            var query = new Query<CashDrawerEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawerEdge>(query);
            return this;
        }

        public CashDrawerConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawer>(query);
            return this;
        }

        public CashDrawerConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}