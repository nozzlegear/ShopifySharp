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
    public sealed class QueryRootPointOfSaleDevicePaymentSessionsQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevicePaymentSessionConnection, QueryRootPointOfSaleDevicePaymentSessionsQueryBuilder>, IHasArguments<QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder>
    {
        public QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder Arguments { get; }
        protected override QueryRootPointOfSaleDevicePaymentSessionsQueryBuilder Self => this;

        public QueryRootPointOfSaleDevicePaymentSessionsQueryBuilder(string name) : base(new Query<PointOfSaleDevicePaymentSessionConnection>(name))
        {
            Arguments = new QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPointOfSaleDevicePaymentSessionsQueryBuilder(IQuery<PointOfSaleDevicePaymentSessionConnection> query) : base(query)
        {
            Arguments = new QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPointOfSaleDevicePaymentSessionsQueryBuilder SetArguments(Action<QueryRootPointOfSaleDevicePaymentSessionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionEdgeQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSessionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSessionEdge>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSession>(query);
            return this;
        }

        public QueryRootPointOfSaleDevicePaymentSessionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}