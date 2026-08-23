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
    public sealed class PointOfSaleDevicePaymentSessionCountOperationQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevicePaymentSessionCountPayload, PointOfSaleDevicePaymentSessionCountOperationQueryBuilder>, IGraphOperationQueryBuilder<PointOfSaleDevicePaymentSessionCountPayload>, IHasArguments<PointOfSaleDevicePaymentSessionCountArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PointOfSaleDevicePaymentSessionCountArgumentsBuilder Arguments { get; }
        protected override PointOfSaleDevicePaymentSessionCountOperationQueryBuilder Self => this;

        public PointOfSaleDevicePaymentSessionCountOperationQueryBuilder() : this("pointOfSaleDevicePaymentSessionCount")
        {
        }

        public PointOfSaleDevicePaymentSessionCountOperationQueryBuilder(string name) : base(new Query<PointOfSaleDevicePaymentSessionCountPayload>(name))
        {
            Arguments = new PointOfSaleDevicePaymentSessionCountArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionCountOperationQueryBuilder(IQuery<PointOfSaleDevicePaymentSessionCountPayload> query) : base(query)
        {
            Arguments = new PointOfSaleDevicePaymentSessionCountArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDevicePaymentSessionCountOperationQueryBuilder SetArguments(Action<PointOfSaleDevicePaymentSessionCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCountOperationQueryBuilder PointOfSaleDevicePaymentSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("pointOfSaleDevicePaymentSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSession>(query);
            return this;
        }

        public PointOfSaleDevicePaymentSessionCountOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionCountUserErrorQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSessionCountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionCountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSessionCountUserError>(query);
            return this;
        }
    }
}