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
    public sealed class PointOfSaleDevicePaymentSessionOpenOperationQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevicePaymentSessionOpenPayload, PointOfSaleDevicePaymentSessionOpenOperationQueryBuilder>, IGraphOperationQueryBuilder<PointOfSaleDevicePaymentSessionOpenPayload>, IHasArguments<PointOfSaleDevicePaymentSessionOpenArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PointOfSaleDevicePaymentSessionOpenArgumentsBuilder Arguments { get; }
        protected override PointOfSaleDevicePaymentSessionOpenOperationQueryBuilder Self => this;

        public PointOfSaleDevicePaymentSessionOpenOperationQueryBuilder() : this("pointOfSaleDevicePaymentSessionOpen")
        {
        }

        public PointOfSaleDevicePaymentSessionOpenOperationQueryBuilder(string name) : base(new Query<PointOfSaleDevicePaymentSessionOpenPayload>(name))
        {
            Arguments = new PointOfSaleDevicePaymentSessionOpenArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionOpenOperationQueryBuilder(IQuery<PointOfSaleDevicePaymentSessionOpenPayload> query) : base(query)
        {
            Arguments = new PointOfSaleDevicePaymentSessionOpenArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionOpenOperationQueryBuilder SetArguments(Action<PointOfSaleDevicePaymentSessionOpenArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOpenOperationQueryBuilder PointOfSaleDevicePaymentSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("pointOfSaleDevicePaymentSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSession>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionOpenOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionOpenUserErrorQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSessionOpenUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionOpenUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSessionOpenUserError>(query);
            return this;
        }
    }
}