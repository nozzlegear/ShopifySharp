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
    public sealed class CashDrawerCashActivitiesQueryBuilder : FieldsQueryBuilderBase<CashActivityConnection, CashDrawerCashActivitiesQueryBuilder>, IHasArguments<CashDrawerCashActivitiesArgumentsBuilder>
    {
        public CashDrawerCashActivitiesArgumentsBuilder Arguments { get; }
        protected override CashDrawerCashActivitiesQueryBuilder Self => this;

        public CashDrawerCashActivitiesQueryBuilder(string name) : base(new Query<CashActivityConnection>(name))
        {
            Arguments = new CashDrawerCashActivitiesArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerCashActivitiesQueryBuilder(IQuery<CashActivityConnection> query) : base(query)
        {
            Arguments = new CashDrawerCashActivitiesArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerCashActivitiesQueryBuilder SetArguments(Action<CashDrawerCashActivitiesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashDrawerCashActivitiesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityEdgeQueryBuilder> build)
        {
            var query = new Query<CashActivityEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashActivityEdge>(query);
            return this;
        }

        public CashDrawerCashActivitiesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityQueryBuilder> build)
        {
            var query = new Query<ICashActivity>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICashActivity>(query);
            return this;
        }

        public CashDrawerCashActivitiesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}