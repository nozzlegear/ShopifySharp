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
    public sealed class CashDrawersOperationQueryBuilder : FieldsQueryBuilderBase<CashDrawerConnection, CashDrawersOperationQueryBuilder>, IGraphOperationQueryBuilder<CashDrawerConnection>, IHasArguments<CashDrawersArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CashDrawersArgumentsBuilder Arguments { get; }
        protected override CashDrawersOperationQueryBuilder Self => this;

        public CashDrawersOperationQueryBuilder() : this("cashDrawers")
        {
        }

        public CashDrawersOperationQueryBuilder(string name) : base(new Query<CashDrawerConnection>(name))
        {
            Arguments = new CashDrawersArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawersOperationQueryBuilder(IQuery<CashDrawerConnection> query) : base(query)
        {
            Arguments = new CashDrawersArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawersOperationQueryBuilder SetArguments(Action<CashDrawersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashDrawersOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerEdgeQueryBuilder> build)
        {
            var query = new Query<CashDrawerEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawerEdge>(query);
            return this;
        }

        public CashDrawersOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawer>(query);
            return this;
        }

        public CashDrawersOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}