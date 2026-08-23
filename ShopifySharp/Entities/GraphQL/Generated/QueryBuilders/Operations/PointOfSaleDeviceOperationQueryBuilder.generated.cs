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
    public sealed class PointOfSaleDeviceOperationQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevice, PointOfSaleDeviceOperationQueryBuilder>, IGraphOperationQueryBuilder<PointOfSaleDevice>, IHasArguments<PointOfSaleDeviceArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public PointOfSaleDeviceArgumentsBuilder Arguments { get; }
        protected override PointOfSaleDeviceOperationQueryBuilder Self => this;

        public PointOfSaleDeviceOperationQueryBuilder() : this("pointOfSaleDevice")
        {
        }

        public PointOfSaleDeviceOperationQueryBuilder(string name) : base(new Query<PointOfSaleDevice>(name))
        {
            Arguments = new PointOfSaleDeviceArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDeviceOperationQueryBuilder(IQuery<PointOfSaleDevice> query) : base(query)
        {
            Arguments = new PointOfSaleDeviceArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDeviceOperationQueryBuilder SetArguments(Action<PointOfSaleDeviceArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PointOfSaleDeviceOperationQueryBuilder ActivePaymentSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("activePaymentSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSession>(query);
            return this;
        }

        public PointOfSaleDeviceOperationQueryBuilder CashDrawer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("cashDrawer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawer>(query);
            return this;
        }

        public PointOfSaleDeviceOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}