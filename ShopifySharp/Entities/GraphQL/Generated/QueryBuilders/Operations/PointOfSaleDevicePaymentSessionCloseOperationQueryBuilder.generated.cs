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
    public sealed class PointOfSaleDevicePaymentSessionCloseOperationQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevicePaymentSessionClosePayload, PointOfSaleDevicePaymentSessionCloseOperationQueryBuilder>, IGraphOperationQueryBuilder<PointOfSaleDevicePaymentSessionClosePayload>, IHasArguments<PointOfSaleDevicePaymentSessionCloseArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PointOfSaleDevicePaymentSessionCloseArgumentsBuilder Arguments { get; }
        protected override PointOfSaleDevicePaymentSessionCloseOperationQueryBuilder Self => this;

        public PointOfSaleDevicePaymentSessionCloseOperationQueryBuilder() : this("pointOfSaleDevicePaymentSessionClose")
        {
        }

        public PointOfSaleDevicePaymentSessionCloseOperationQueryBuilder(string name) : base(new Query<PointOfSaleDevicePaymentSessionClosePayload>(name))
        {
            Arguments = new PointOfSaleDevicePaymentSessionCloseArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionCloseOperationQueryBuilder(IQuery<PointOfSaleDevicePaymentSessionClosePayload> query) : base(query)
        {
            Arguments = new PointOfSaleDevicePaymentSessionCloseArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionCloseOperationQueryBuilder SetArguments(Action<PointOfSaleDevicePaymentSessionCloseArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCloseOperationQueryBuilder PointOfSaleDevicePaymentSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("pointOfSaleDevicePaymentSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSession>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCloseOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionCloseUserErrorQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSessionCloseUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionCloseUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSessionCloseUserError>(query);
            return this;
        }
    }
}