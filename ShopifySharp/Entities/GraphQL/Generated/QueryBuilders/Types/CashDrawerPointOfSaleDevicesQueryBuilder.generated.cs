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
    public sealed class CashDrawerPointOfSaleDevicesQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDeviceConnection, CashDrawerPointOfSaleDevicesQueryBuilder>, IHasArguments<CashDrawerPointOfSaleDevicesArgumentsBuilder>
    {
        public CashDrawerPointOfSaleDevicesArgumentsBuilder Arguments { get; }
        protected override CashDrawerPointOfSaleDevicesQueryBuilder Self => this;

        public CashDrawerPointOfSaleDevicesQueryBuilder(string name) : base(new Query<PointOfSaleDeviceConnection>(name))
        {
            Arguments = new CashDrawerPointOfSaleDevicesArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerPointOfSaleDevicesQueryBuilder(IQuery<PointOfSaleDeviceConnection> query) : base(query)
        {
            Arguments = new CashDrawerPointOfSaleDevicesArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerPointOfSaleDevicesQueryBuilder SetArguments(Action<CashDrawerPointOfSaleDevicesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashDrawerPointOfSaleDevicesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceEdgeQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDeviceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDeviceEdge>(query);
            return this;
        }

        public CashDrawerPointOfSaleDevicesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevice>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevice>(query);
            return this;
        }

        public CashDrawerPointOfSaleDevicesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}