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
    public sealed class PointOfSaleDevicePaymentSessionAdjustOperationQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevicePaymentSessionAdjustPayload, PointOfSaleDevicePaymentSessionAdjustOperationQueryBuilder>, IGraphOperationQueryBuilder<PointOfSaleDevicePaymentSessionAdjustPayload>, IHasArguments<PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder Arguments { get; }
        protected override PointOfSaleDevicePaymentSessionAdjustOperationQueryBuilder Self => this;

        public PointOfSaleDevicePaymentSessionAdjustOperationQueryBuilder() : this("pointOfSaleDevicePaymentSessionAdjust")
        {
        }

        public PointOfSaleDevicePaymentSessionAdjustOperationQueryBuilder(string name) : base(new Query<PointOfSaleDevicePaymentSessionAdjustPayload>(name))
        {
            Arguments = new PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionAdjustOperationQueryBuilder(IQuery<PointOfSaleDevicePaymentSessionAdjustPayload> query) : base(query)
        {
            Arguments = new PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionAdjustOperationQueryBuilder SetArguments(Action<PointOfSaleDevicePaymentSessionAdjustArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PointOfSaleDevicePaymentSessionAdjustOperationQueryBuilder PointOfSaleDevicePaymentSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("pointOfSaleDevicePaymentSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSession>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionAdjustOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}