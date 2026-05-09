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
    public sealed class PointOfSaleDevicePaymentSessionCashActivitiesQueryBuilder : FieldsQueryBuilderBase<CashActivityConnection, PointOfSaleDevicePaymentSessionCashActivitiesQueryBuilder>, IHasArguments<PointOfSaleDevicePaymentSessionCashActivitiesArgumentsBuilder>
    {
        public PointOfSaleDevicePaymentSessionCashActivitiesArgumentsBuilder Arguments { get; }
        protected override PointOfSaleDevicePaymentSessionCashActivitiesQueryBuilder Self => this;

        public PointOfSaleDevicePaymentSessionCashActivitiesQueryBuilder(string name) : base(new Query<CashActivityConnection>(name))
        {
            Arguments = new PointOfSaleDevicePaymentSessionCashActivitiesArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionCashActivitiesQueryBuilder(IQuery<CashActivityConnection> query) : base(query)
        {
            Arguments = new PointOfSaleDevicePaymentSessionCashActivitiesArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionCashActivitiesQueryBuilder SetArguments(Action<PointOfSaleDevicePaymentSessionCashActivitiesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCashActivitiesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityEdgeQueryBuilder> build)
        {
            var query = new Query<CashActivityEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashActivityEdge>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCashActivitiesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityQueryBuilder> build)
        {
            var query = new Query<ICashActivity>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICashActivity>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCashActivitiesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}