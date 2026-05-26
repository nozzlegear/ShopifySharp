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
    public sealed class PointOfSaleDevicePaymentSessionsOperationQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevicePaymentSessionConnection, PointOfSaleDevicePaymentSessionsOperationQueryBuilder>, IGraphOperationQueryBuilder<PointOfSaleDevicePaymentSessionConnection>, IHasArguments<PointOfSaleDevicePaymentSessionsArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public PointOfSaleDevicePaymentSessionsArgumentsBuilder Arguments { get; }
        protected override PointOfSaleDevicePaymentSessionsOperationQueryBuilder Self => this;

        public PointOfSaleDevicePaymentSessionsOperationQueryBuilder() : this("pointOfSaleDevicePaymentSessions")
        {
        }

        public PointOfSaleDevicePaymentSessionsOperationQueryBuilder(string name) : base(new Query<PointOfSaleDevicePaymentSessionConnection>(name))
        {
            Arguments = new PointOfSaleDevicePaymentSessionsArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionsOperationQueryBuilder(IQuery<PointOfSaleDevicePaymentSessionConnection> query) : base(query)
        {
            Arguments = new PointOfSaleDevicePaymentSessionsArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionsOperationQueryBuilder SetArguments(Action<PointOfSaleDevicePaymentSessionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PointOfSaleDevicePaymentSessionsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionEdgeQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSessionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSessionEdge>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSession>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}